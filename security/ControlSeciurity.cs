using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Kontroler.security
{
    class ControlSeciurity
    {
        [DllImport("User32.dll")]
        public static extern void LockWorkStation();
        public void Control()
        {
            blocked();
        }
        void blocked()
        {
            LockWorkStation();
        }
    }
}
