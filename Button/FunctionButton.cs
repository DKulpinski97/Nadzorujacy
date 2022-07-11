using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Kontroler.File;

namespace Kontroler.Button
{
    class FunctionButton
    {
        public string TakePathRead(OpenFileDialog Path, TextBox PathToRead)
        {

            string tmp = null;
            if (Path.ShowDialog() == DialogResult.OK)
            {
                //Wyświetlanie plikow w folderze
                Path.Filter = "Text files(*.tex)|*.csv|All files(*.*)|*.*";
                tmp = Path.FileName;
                PathToRead.Text = tmp;
            }
            return tmp;
        }
         public bool CheckPath(string Path)
        {
            FileSupport file = new FileSupport();
            if (file.CheckPath(Path) == true && file.CheckExtension(Path) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
