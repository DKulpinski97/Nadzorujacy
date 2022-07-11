using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kontroler.Button;
using Kontroler.File;
using static Kontroler.File.PriperSimbols;

namespace Kontroler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<List<PriperWords>> Words = new List<List<PriperWords>>();
        List<aplication> aplications = new List<aplication>();
        int HowMenyErrors = 0;
        int HangeFokus = 0;
        int breakTime = 0;

        private void Start_Click(object sender, EventArgs e)
        {
            long BadTime = 0;
            if(TimeToBeak.Text!="")
            {
                try
                {
                    BadTime = Convert.ToInt32(TimeToBeak.Text);
                    if(BadTime<0)
                    {
                        MessageBox.Show("Podana wartość błędngo czasu musi być wieksza od zera");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Podana wartość błednego czasu musi być liczbą dodatnią");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Czas do uznania błędnego czasu musi być wyznaczony");
                return;
            }
            

            if (Words.Count > 0 && HowMenyErrors > 0 && HangeFokus > 0&& breakTime > 0&&aplications.Count>0)
            {
                this.Hide();
                Main main = new Main();
                main.MainProgram(Words, HowMenyErrors, HangeFokus,breakTime, aplications, BadTime);
            }
            else
            {
                MessageBox.Show("nie załadowano pliku lub jeden z parametrów nie został dodany");
            }
        }

        private void PathToFile_Click(object sender, EventArgs e)
        {
            FunctionButton functionButton = new FunctionButton();
            PathFile.Text = "";
            var path = new OpenFileDialog();
            functionButton.TakePathRead(path, PathFile);
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            Words = new List<List<PriperWords>>();
            FileSupport fileSupport = new FileSupport();
            List<PriperWords> Lains = new List<PriperWords>();
            FunctionButton functionButton = new FunctionButton();
            Kontroler.Shering.Shering shering = new Shering.Shering();
            if (PathFile.Text == "" || PathAplication.Text=="")
            {
                MessageBox.Show("Nie wybrano ścierzki do pliku");
                return;
            }
            //Odczyt danych do pisma
            if (functionButton.CheckPath(PathFile.Text) == true)
            {
                string[] allLine = fileSupport.Read(PathFile.Text);
                //Przepisywanie lnijki do konkretnych zmienych
                for (int i = 1; i < allLine.Length; i++)
                {

                    PriperWords priperWords = new PriperWords();
                    shering.SheringLine(priperWords, allLine[i]);
                    Lains.Add(priperWords);
                }
                allLine = null;
                //łączenie symboli w jeden ciąg
                Words = shering.CreatWord(Lains);
                //Z powodu błędu przy wczytywaniu nie potrafie znależ trzeba usunąć nadmiarowy wiersz ostati
                Words.RemoveAt(Words.Count - 1);
            }
            else
            {
                MessageBox.Show("Wybrany plik z pismem nie ma roszerzenai CSV");
            }
            //Odczyt danych do aplikacji
            if (functionButton.CheckPath(PathAplication.Text) == true)
            {
                string[] aplication = fileSupport.Read(PathAplication.Text);
                //Przepisywanie lnijki do konkretnych zmienych
                for (int i = 0; i < aplication.Length; i++)
                {

                    aplication aplikation = new aplication();
                    aplikation.Aplication = aplication[i];
                    aplications.Add(aplikation);
                }
               // allLine = null;
                //łączenie symboli w jeden ciąg
                //Z powodu błędu przy wczytywaniu nie potrafie znależ trzeba usunąć nadmiarowy wiersz ostati
                Words.RemoveAt(Words.Count - 1);
            }
            else
            {
                MessageBox.Show("Wybrany plik z aplikacjiami nie ma roszerzenai CSV");
            }
        }

        private void LoadLimits_Click(object sender, EventArgs e)
        {
            HowMenyErrors = 0;
            HangeFokus = 0;
            breakTime = 0;
            try
            {
                HowMenyErrors = int.Parse(HowMenyError.Text);
                HangeFokus = int.Parse(changeFokus.Text);
                breakTime = int.Parse(BreakTime.Text);
            }
            catch
            {
                MessageBox.Show("Wartości podane w polach nie są liczbami całkowitymi dodatnimi");
            }

        }

        private void PathToAplication_Click(object sender, EventArgs e)
        {
            FunctionButton functionButton = new FunctionButton();
            PathAplication.Text = "";
            var path = new OpenFileDialog();
            functionButton.TakePathRead(path, PathAplication);
        }
    }
}
