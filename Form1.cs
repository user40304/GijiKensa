using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using GijiKensa.Api;
using GijiKensa.Api.Win32Api;

namespace GijiKensa {
    public partial class Form1 : Form {

        private int prew_sw = 0x00;
        bool result = false;

        public Form1() {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e) {
            serialPort1.Open();

            serialPort1.RtsEnable = true;
            Thread.Sleep(100);
            serialPort1.RtsEnable = false;
            Thread.Sleep(300);

            serialPort1.DiscardInBuffer();
            timer1.Enabled = true;

            ClearResult();

            using (StreamReader file = new StreamReader("data.csv")) {
                while (!file.EndOfStream) {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');

                    resultData.DataTable.AddDataTableRow(
                        DateTime.Parse(data[0]),
                        int.Parse(data[1]),
                        float.Parse(data[2]),
                        data[3]
                    );

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            int sw;

            {
                //string line = SerialWriteResult("I");
                string line = SerialWriteResult("C");
                sw = int.Parse(line, System.Globalization.NumberStyles.HexNumber);
            }

            if ((sw & 0x01) != 0x00 && sw != prew_sw) {
                result = false;
                int result_num = 0;

                NichijiLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                // センサー
                int sensor_value;

                {
                    string line = SerialWriteResult("S");
                    SensorLabel.Text = line;
                    sensor_value = int.Parse(line);

                    if (500 <= sensor_value && sensor_value <= 550) {
                        result_num++;
                    }
                }

                // TSW8
                {
                    if ((sw & 0x80) != 0x00) {
                        result_num++;
                    }
                }

                // デジタル値取得検査
                int digtal_value;

                {
                    string line = SerialWriteResult("D");
                    digtal_value = int.Parse(line);
                    digtalLabel.Text = line.Substring(1, 1);

                    if (3 <= digtal_value && digtal_value <= 5) {
                        result_num++;
                    }
                }

                // 温度
                float tmp;

                {
                    string line = SerialWriteResult("0");
                    tmp = float.Parse(line);
                    tmpLabel.Text = line;

                    if (14.0f <= tmp && tmp <= 26.0f) {
                        result_num++;
                    }
                }

                if (result_num == 4) {
                    result = true;
                }

                {
                    serialPort1.Write("3");
                    string line = serialPort1.ReadLine();
                    IncrementLabel.Text = line;
                }

                if (result == true) {
                    ResultLabel.Text = "OK";
                    ResultLabel.BackColor = Color.Blue;
                    ResultLabel.ForeColor = Color.White;

                } else {
                    ResultLabel.Text = "NG";
                    ResultLabel.BackColor = Color.Red;
                    ResultLabel.ForeColor = Color.White;
                }

                System.IO.File.AppendAllText(
                    "data.csv",
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "," + SensorLabel.Text + "," + tmpLabel.Text + "," + ResultLabel.Text + "\n"
                );


            } else if ((sw & 0x02) != 0x00) {
                ClearResult();
            } else {

            }

            if (result == true) {
                serialPort1.Write("L");
            } else {
                serialPort1.Write("l");
            }

            string datas = "";

            using (StreamReader file = new StreamReader("data.csv")) {
                while (!file.EndOfStream) {
                    string line = file.ReadLine();

                    datas += line + "\n";
                }
            }

            NotePad_Write.SetText("notepad", 0, "Edit", datas);

            prew_sw = sw;
        }

        private void ClearResult() {
            result = false;

            ResultLabel.Text = "--";
            ResultLabel.BackColor = Color.White;
            ResultLabel.ForeColor = Color.Black;


            NichijiLabel.Text = "-";
            SensorLabel.Text = "-";
            IncrementLabel.Text = "-";
            digtalLabel.Text = "-";
            tmpLabel.Text = "-";
        }

        private string SerialWriteResult(string cmd) {
            serialPort1.Write(cmd);

            return serialPort1.ReadLine();
        }
    }
}
