using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GijiKensa.Api.Win32Api {
    class SendMessage_wpf {
        [DllImport("User32.dll")]
        public extern static int SendMessage(IntPtr hWnd, UIntPtr Msg, IntPtr wParam, String lParam);

        public static UIntPtr WM_SETTEXT = (UIntPtr)0x000C;
    }
}
