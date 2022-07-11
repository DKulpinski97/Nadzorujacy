using Keyloger.Char;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Keyloger.Time;
using static Kontroler.File.PriperSimbols;
using Kontroler.Focus;
using Kontroler.security;

namespace Kontroler.Control
{
    class Control
    {
        long oldMilisekends = 0;
        int badstartpoziton = -1;
        int[] returnig = new int[2];
        string oldFokus = "";
        List<OneChar> controlstring = new List<OneChar>();
        OneChar oneChar;
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 Stateshift);
        public int[] ControlData(int HowMenyError, int HowMenychangeFokus, int keyNumber, int MaxFailTime, List<List<PriperWords>> Words, int[] sumarry, List<aplication> aplication,long badTime)
        {
            
            int badwords = sumarry[0];
            int maxString = Words[Words.Count-1].Count;
            controlstring.Add(PriperChar(keyNumber,  badTime));
            
            if (controlstring.Count== maxString+1)
            {
                controlstring.RemoveAt(0);
            }
            if(controlstring[controlstring.Count-1].TimeToClick==-1)
            {
                sumarry[2]++;
            }
            Check.Check check = new Check.Check();
            returnig = check.ChekTime(Words, controlstring, badstartpoziton);
            badstartpoziton = returnig[1];
            sumarry[0] += returnig[0];
            ControlSeciurity controlSeciurity = new ControlSeciurity();
            if (badstartpoziton<0)
            {
                badstartpoziton = -1;
            }
            //blokada ekranu
            if(badwords== HowMenyError)
            {
                controlSeciurity.Control();
            }
            if(check.CheckFokus(controlstring[controlstring.Count - 1].focus,oldFokus)==false)
            {
                sumarry[1]++;
            }
            if(sumarry[1]>= HowMenychangeFokus)
            {
                controlSeciurity.Control();
            }
            if(sumarry[2] >= MaxFailTime)
            {
                controlSeciurity.Control();
            }
            if(check.goodAplikation(controlstring[controlstring.Count - 1].focus,aplication)==false)
            {
                controlSeciurity.Control();
            }
            oldFokus = controlstring[controlstring.Count - 1].focus;
            return sumarry;

        }
        public OneChar PriperChar(int keyNumber, long badTime)
        {
            bool StatusCtrl = false;
            bool StatusNumlock = false;
            Time time = new Time();
            long nowMilisekends = time.takeTimeInMilliseconds();
            Keyloger.Char.Check check = new Keyloger.Char.Check();
            FocusMonitor focus = new FocusMonitor();
            if (GetAsyncKeyState(18) == 0 || GetAsyncKeyState(165) == 0)
            {
                StatusCtrl = check.Ctrl();
            }
            //Sprawdzanie czy potrzebny jest namlok do znaku
            if ((keyNumber >= 97 && keyNumber <= 105) || keyNumber == 110)
            {
                StatusNumlock = true;
            }
            oneChar = new OneChar();
            oneChar.code = keyNumber;
            oneChar.numLock = StatusNumlock;
            oneChar.PAlt = check.AltState();
            oneChar.bigLiter = check.BigLiterStatus();
            oneChar.focus = focus.Focus();
            oneChar.TimeToClick = time.ClickTime(oldMilisekends, nowMilisekends,  badTime);
            oldMilisekends = nowMilisekends;
            return oneChar;
        }
    }
}
