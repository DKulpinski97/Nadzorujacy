using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Kontroler.File.PriperSimbols;
using Keyloger.Time;

namespace Kontroler
{
    class Main
    {
        //Zbieranie klawiszy z każdego okna

        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 KeyNumber);
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);



        int[] sumarry = new int[3];
        int controlWords=-1;
        int controlFokus = -1;
        int BreakTime = -1;
        static int terminal = 0;
        public void MainProgram(List<List<PriperWords>> Words, int HowMenyErrors, int HangeFokus,int breakTime, List<aplication> aplication,long BadTime)
        {
            Control.Control control = new Control.Control();
            int j = 0;
            //sumarry 0 odnosi się do złych słów natoomiast 1 to zmiany fokusa 2 to przerwy w pisaniu
            sumarry[0] = 0;
            sumarry[1] = 0;
            sumarry[2] = 0;
            Thread badwords = new Thread(RestartWords);
            Thread fokus = new Thread(RestartFokus);
            while (j == 0)
            {

                Thread.Sleep(5);
                for (int i = 0; i < 255; i++)
                {

                    var keyStatus = GetAsyncKeyState(i);
                    //Wyrzucenie klawiszy ktury wysyłają kilkakrotnie sygnału klawiszy np Palt lub Pctrl
                    if (keyStatus == 32769 && !(i >= 17 && i <= 18) && !(i >= 162 && i <= 165))
                    {
                        sumarry=control.ControlData(HowMenyErrors, HangeFokus, i, breakTime, Words, sumarry, aplication, BadTime);
                    }
                    if(keyStatus == 32769 && i ==162)
                    {
                        //Tworzenie wontu
                        Thread wontek = new Thread(RestartTerminal);
                        wontek.Start();

                        if (terminal==3)
                        {
                            MessageBox.Show("Pokazanie terminala ");
                            terminal = 0;
                            Form1 form1 = new Form1();
                            form1.Show();
                            j = 1;

                            
                        }
                        
                        
                        terminal++;
                    }


                }
                if(sumarry [0]>= HowMenyErrors|| controlWords==-1)
                {
                    controlWords = 0;
                    sumarry[0] = 0;
                    
                    badwords = new Thread(RestartWords);
                    badwords.Start(3600000);
                }
                if (sumarry[1] >= HangeFokus || controlFokus == -1)
                {
                    controlFokus = 0;
                    sumarry[1] = 0;
                    
                    badwords = new Thread(RestartWords);
                    badwords.Start(180000);
                }
                if (sumarry[2] >= breakTime || BreakTime == -1)
                {
                    BreakTime = 0;
                    sumarry[2] = 0;
                    badwords = new Thread(RestartBreakTime);
                    badwords.Start(180000);
                }

            }
        }
        static void RestartTerminal()
        {
            Thread.Sleep(1000);
            terminal = 0;
        }
        public void RestartWords(object time)
        {
                Thread.Sleep(int.Parse(time.ToString()));
                sumarry[0] = 0;
                controlWords = -1;
        }
        public void RestartFokus(object time)
        {
            Thread.Sleep(int.Parse(time.ToString()));
            sumarry[1] = 0;
            controlFokus = -1;
        }
        public void RestartBreakTime(object time)
        {
            Thread.Sleep(int.Parse(time.ToString()));
            sumarry[2] = 0;
            BreakTime = -1;
        }
    }
}
