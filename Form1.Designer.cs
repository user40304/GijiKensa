
namespace GijiKensa {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NichijiLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SensorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IncrementLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.digtalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmpLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.日時DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aD値DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.温度DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.検査結果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultData = new GijiKensa.ResultData();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultData)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM21";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(229, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "日時";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NichijiLabel
            // 
            this.NichijiLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NichijiLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NichijiLabel.Location = new System.Drawing.Point(344, 33);
            this.NichijiLabel.Name = "NichijiLabel";
            this.NichijiLabel.Size = new System.Drawing.Size(118, 47);
            this.NichijiLabel.TabIndex = 2;
            this.NichijiLabel.Text = "-";
            this.NichijiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(229, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 47);
            this.label3.TabIndex = 2;
            this.label3.Text = "センサー";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SensorLabel
            // 
            this.SensorLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SensorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SensorLabel.Location = new System.Drawing.Point(344, 96);
            this.SensorLabel.Name = "SensorLabel";
            this.SensorLabel.Size = new System.Drawing.Size(118, 47);
            this.SensorLabel.TabIndex = 3;
            this.SensorLabel.Text = "-";
            this.SensorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(229, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "インクリメント";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IncrementLabel
            // 
            this.IncrementLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IncrementLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncrementLabel.Location = new System.Drawing.Point(344, 168);
            this.IncrementLabel.Name = "IncrementLabel";
            this.IncrementLabel.Size = new System.Drawing.Size(118, 47);
            this.IncrementLabel.TabIndex = 5;
            this.IncrementLabel.Text = "-";
            this.IncrementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultLabel.Location = new System.Drawing.Point(30, 33);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(160, 85);
            this.ResultLabel.TabIndex = 6;
            this.ResultLabel.Text = "-";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digtalLabel
            // 
            this.digtalLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.digtalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digtalLabel.Location = new System.Drawing.Point(344, 243);
            this.digtalLabel.Name = "digtalLabel";
            this.digtalLabel.Size = new System.Drawing.Size(118, 47);
            this.digtalLabel.TabIndex = 8;
            this.digtalLabel.Text = "-";
            this.digtalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(229, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 47);
            this.label4.TabIndex = 7;
            this.label4.Text = "デジタルセンサー";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmpLabel
            // 
            this.tmpLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tmpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tmpLabel.Location = new System.Drawing.Point(344, 313);
            this.tmpLabel.Name = "tmpLabel";
            this.tmpLabel.Size = new System.Drawing.Size(118, 47);
            this.tmpLabel.TabIndex = 10;
            this.tmpLabel.Text = "-";
            this.tmpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(229, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 47);
            this.label6.TabIndex = 9;
            this.label6.Text = "温度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日時DataGridViewTextBoxColumn,
            this.aD値DataGridViewTextBoxColumn,
            this.温度DataGridViewTextBoxColumn,
            this.検査結果DataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.dataTableBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(479, 33);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowTemplate.Height = 21;
            this.dataGrid.Size = new System.Drawing.Size(460, 327);
            this.dataGrid.TabIndex = 11;
            // 
            // 日時DataGridViewTextBoxColumn
            // 
            this.日時DataGridViewTextBoxColumn.DataPropertyName = "日時";
            this.日時DataGridViewTextBoxColumn.HeaderText = "日時";
            this.日時DataGridViewTextBoxColumn.Name = "日時DataGridViewTextBoxColumn";
            this.日時DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aD値DataGridViewTextBoxColumn
            // 
            this.aD値DataGridViewTextBoxColumn.DataPropertyName = "AD値";
            this.aD値DataGridViewTextBoxColumn.HeaderText = "AD値";
            this.aD値DataGridViewTextBoxColumn.Name = "aD値DataGridViewTextBoxColumn";
            this.aD値DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 温度DataGridViewTextBoxColumn
            // 
            this.温度DataGridViewTextBoxColumn.DataPropertyName = "温度";
            this.温度DataGridViewTextBoxColumn.HeaderText = "温度";
            this.温度DataGridViewTextBoxColumn.Name = "温度DataGridViewTextBoxColumn";
            this.温度DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 検査結果DataGridViewTextBoxColumn
            // 
            this.検査結果DataGridViewTextBoxColumn.DataPropertyName = "検査結果";
            this.検査結果DataGridViewTextBoxColumn.HeaderText = "検査結果";
            this.検査結果DataGridViewTextBoxColumn.Name = "検査結果DataGridViewTextBoxColumn";
            this.検査結果DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.resultData;
            // 
            // resultData
            // 
            this.resultData.DataSetName = "ResultData";
            this.resultData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 385);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.tmpLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.digtalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.IncrementLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SensorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NichijiLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(967, 424);
            this.MinimumSize = new System.Drawing.Size(967, 424);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NichijiLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SensorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label IncrementLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label digtalLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tmpLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日時DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aD値DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 温度DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 検査結果DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private ResultData resultData;
    }
}

