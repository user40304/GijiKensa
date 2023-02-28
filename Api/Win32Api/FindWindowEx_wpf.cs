using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GijiKensa.Api.Win32Api {
    class FindWindowEx_wpf {
        [DllImport("User32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, String lpszClass, String lpszWindow);

    }
}
