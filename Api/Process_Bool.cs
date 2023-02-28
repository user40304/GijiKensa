using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GijiKensa.Api {
    class Process_Bool {
        public static bool GetProcess_Bool(String ProcessName) {

            int processes = Process.GetProcessesByName(ProcessName).Length;

            if (processes > 0) {
                return true;
            } else {

                return false;
            }
        }
    }
}
