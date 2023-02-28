using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GijiKensa.Api {
    class NotePad_Write {
        public static bool SetText(String processname, int handlenumber, String childname, String message) {

            IntPtr mainHandle;
            bool process_bool = Api.Process_Bool.GetProcess_Bool(processname);

            if (process_bool == true) {
                mainHandle = Process.GetProcessesByName(processname)[handlenumber].MainWindowHandle;
            } else {
                return false;
            }

            IntPtr mainChild = Api.Win32Api.FindWindowEx_wpf.FindWindowEx(mainHandle, (IntPtr)0, childname, null);

            Api.Win32Api.SendMessage_wpf.SendMessage(mainChild, Api.Win32Api.SendMessage_wpf.WM_SETTEXT, (IntPtr)0, message);

            return true;
        }
    }
}
