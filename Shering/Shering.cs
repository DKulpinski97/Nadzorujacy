using System;
using System.Collections.Generic;
using System.Text;
using static Kontroler.File.PriperSimbols;

namespace Kontroler.Shering
{
    class Shering
    {
        public void SheringLine(PriperWords priper, string line)
        {
            string code = null;
            int tmp = 0;
            for (int i = 0; i < line.Length-1; i++)
            {
                if (line[i] == ';')
                {
                    if (line != ";;;;;")
                    {
                        if (tmp == 0)
                        {
                            priper.code = Int32.Parse(code);
                        }
                        if (tmp == 1)
                        {
                            priper.bigLiter = Boolean.Parse(code);
                        }
                        if (tmp == 2)
                        {
                            priper.numLock = Boolean.Parse(code);
                        }
                        if (tmp == 3)
                        {
                            priper.PAlt = Boolean.Parse(code);
                        }
                        if (tmp == 4)
                        {
                            code.Replace(',', '.');
                            priper.averageTime = float.Parse(code);
                        }
                        tmp++;
                        code = "";
                        i++;
                    }

                }
                code += line[i];

            }
            if (line != ";;;;;")
            {
                code.Replace(',', '.');
                priper.deviation = float.Parse(code);
            }

        }

        public List<List<PriperWords>> CreatWord(List<PriperWords> Lains)
        {
            List<List<PriperWords>> Words = new List<List<PriperWords>>();
            List<PriperWords> Word = new List<PriperWords>();
            for (int i = 0; i < Lains.Count; i++)
            {
                if (Lains[i].code != 0)
                {
                    Word.Add(Lains[i]);
                }
                else
                {
                    Words.Add(Word);
                    Word = new List<PriperWords>();
                }
            }
            Words.Add(Word);
            return Words;
        }
    }
}

