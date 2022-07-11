using System;
using System.Collections.Generic;
using System.Text;
using static Kontroler.File.PriperSimbols;

namespace Kontroler.Check
{
    class Check
    {
        public int[] ChekTime(List<List<PriperWords>> Words, List<OneChar> controlstring,int badStartPoziton)
        {
            int[] returning = new int[2];
            int tmp = 0;
            int badString = 0;
            List<OneChar> chekedWords = new List<OneChar>();
            for (int i=0;i< controlstring.Count;i++)
            {
                List<PriperWords> word = new List<PriperWords>(Words[i]);
                if (word.Count <= controlstring.Count)
                {
                    
                    for (int j = 0; j < controlstring.Count - word.Count+1; j++)
                    {
                        if(badStartPoziton == j)
                        {
                            break;
                        }
                        //Wyznaczanie pojedynczego ciągu
                        chekedWords = new List<OneChar>();
                        for (int x = 0; x < word.Count; x++)
                        {
                            chekedWords.Add(controlstring[j + x]);
                        }
                        //sprawdzanie czy identyczne ciągi
                        string focus = chekedWords[0].focus;
                        for (int x=0;x< chekedWords.Count;x++)
                        {
                            
                            if (chekedWords[x].code==word[x].code && chekedWords[x].bigLiter == word[x].bigLiter && 
                                chekedWords[x].numLock == word[x].numLock && chekedWords[x].PAlt == word[x].PAlt&& chekedWords[x].focus== focus)
                            {
                                tmp++;
                            }
                            else
                            {
                                tmp = 0;
                                break;
                            }
                        }
                        if(tmp== chekedWords.Count)
                        {
                            int goodTime = 0;
                            tmp = 0;
                            for(int x=1;x< chekedWords.Count;x++)
                            {
                                //Przerwa w pisaniu ciąg nie nadaje się do sprawdzenia
                                if(chekedWords[x].TimeToClick==-1)
                                {
                                    break;
                                }
                                if(chekedWords[x].TimeToClick<=word[x].averageTime+ word[x].deviation && chekedWords[x].TimeToClick >= word[x].averageTime - word[x].deviation)
                                {
                                }
                                else
                                {
                                    //Ciąg nie spełnia zasady
                                    badStartPoziton = j;
                                    badString++;
                                    break;
                                }
                                
                            }
                        }
                    }
                }
            }
            //zamieszenie  startowej pozycji bo ponownie jej nie brać pod uwagę
            if (badStartPoziton != -1&& controlstring.Count==Words[Words.Count-1].Count)
            {
                badStartPoziton--;
            }
            returning[0] = badString;
            returning[1] = badStartPoziton;
            return returning;
        }
        public bool CheckFokus(string NewFokus,string oldFokus)
        {
            if (oldFokus != "")
            {
                if (NewFokus != oldFokus)
                {
                    return false;
                }
            }
            return true;
        }
        public bool goodAplikation(string Fokus, List<aplication> aplications)
        {
            int tmp = 0;
            string nameAplication = "";

            for(int i= Fokus.Length-1; i>0;i--)
            {
                if(Fokus[i]=='-')
                {
                    break;
                }
                tmp++;
            }
            if (Fokus.Length - 1 == tmp)
            {

                for (int i = 0; i < Fokus.Length; i++)
                {
                    nameAplication += Fokus[i];
                }
            }
            else
            {
                for (int i = Fokus.Length - tmp + 1; i < Fokus.Length; i++)
                {
                    nameAplication += Fokus[i];
                }
            }
            for(int i=0;i< aplications.Count;i++)
            {
                if(aplications[i].Aplication== nameAplication)
                {
                    return true;
                }
            }
             return false;
            
        }



    }
}
