using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Kontroler.File
{
    class FileSupport
    {
        public bool CheckExtension(string Readpath)
        {

            string extension = null;
            for (int i = Readpath.Length - 1; i > 0; i--)
            {
                if (Readpath[i] == '.')
                {
                    break;
                }
                else
                {
                    extension += Readpath[i];
                }
            }
            //Odwracanie strniga
            extension = ReviersArryCharToString(extension);
            if (extension == "csv")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Odczytywany plik nie ma roszeżenia csv");
                return false;
            }
        }
        string ReviersArryCharToString(string str)
        {


            char[] charExtension = str.ToCharArray();
            Array.Reverse(charExtension);
            return new string(charExtension);

        }
        public bool CheckPath(string Readpath)
        {
            if (Readpath != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nie wybrano scieżki");
                return false;
            }
        }
        public string[] Read(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }
    }
}
