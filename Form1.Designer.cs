
namespace Kontroler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PathFile = new System.Windows.Forms.TextBox();
            this.PathToFile = new System.Windows.Forms.Button();
            this.HowMenyError = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeFokus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadFile = new System.Windows.Forms.Button();
            this.LoadLimits = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BreakTime = new System.Windows.Forms.TextBox();
            this.PathToAplication = new System.Windows.Forms.Button();
            this.PathAplication = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeToBeak = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(6, 296);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(494, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Uruchom";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ścieżka do pliku";
            // 
            // PathFile
            // 
            this.PathFile.Location = new System.Drawing.Point(6, 38);
            this.PathFile.Name = "PathFile";
            this.PathFile.Size = new System.Drawing.Size(143, 23);
            this.PathFile.TabIndex = 2;
            // 
            // PathToFile
            // 
            this.PathToFile.Location = new System.Drawing.Point(6, 67);
            this.PathToFile.Name = "PathToFile";
            this.PathToFile.Size = new System.Drawing.Size(143, 23);
            this.PathToFile.TabIndex = 3;
            this.PathToFile.Text = "Ścieżka do pliku";
            this.PathToFile.UseVisualStyleBackColor = true;
            this.PathToFile.Click += new System.EventHandler(this.PathToFile_Click);
            // 
            // HowMenyError
            // 
            this.HowMenyError.Location = new System.Drawing.Point(6, 137);
            this.HowMenyError.Name = "HowMenyError";
            this.HowMenyError.Size = new System.Drawing.Size(143, 23);
            this.HowMenyError.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ile dopuszczalnych błędów w ciągu 1h";
            // 
            // changeFokus
            // 
            this.changeFokus.Location = new System.Drawing.Point(6, 181);
            this.changeFokus.Name = "changeFokus";
            this.changeFokus.Size = new System.Drawing.Size(143, 23);
            this.changeFokus.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ile dozwolonych zmian fokusów w 5 min";
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(6, 93);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(302, 23);
            this.LoadFile.TabIndex = 8;
            this.LoadFile.Text = "Załaduj plik";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // LoadLimits
            // 
            this.LoadLimits.Location = new System.Drawing.Point(6, 251);
            this.LoadLimits.Name = "LoadLimits";
            this.LoadLimits.Size = new System.Drawing.Size(75, 23);
            this.LoadLimits.TabIndex = 9;
            this.LoadLimits.Text = "Załaduj ograniczenia";
            this.LoadLimits.UseVisualStyleBackColor = true;
            this.LoadLimits.Click += new System.EventHandler(this.LoadLimits_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ile dopuszczalnych przerw w pisaniu w ciągu 5 min";
            // 
            // BreakTime
            // 
            this.BreakTime.Location = new System.Drawing.Point(6, 225);
            this.BreakTime.Name = "BreakTime";
            this.BreakTime.Size = new System.Drawing.Size(143, 23);
            this.BreakTime.TabIndex = 11;
            // 
            // PathToAplication
            // 
            this.PathToAplication.Location = new System.Drawing.Point(165, 67);
            this.PathToAplication.Name = "PathToAplication";
            this.PathToAplication.Size = new System.Drawing.Size(143, 23);
            this.PathToAplication.TabIndex = 14;
            this.PathToAplication.Text = "Ścieżka do aplikacji";
            this.PathToAplication.UseVisualStyleBackColor = true;
            this.PathToAplication.Click += new System.EventHandler(this.PathToAplication_Click);
            // 
            // PathAplication
            // 
            this.PathAplication.Location = new System.Drawing.Point(165, 38);
            this.PathAplication.Name = "PathAplication";
            this.PathAplication.Size = new System.Drawing.Size(143, 23);
            this.PathAplication.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ścieżka do dozwolonych aplikacji";
            // 
            // TimeToBeak
            // 
            this.TimeToBeak.Location = new System.Drawing.Point(314, 68);
            this.TimeToBeak.Name = "TimeToBeak";
            this.TimeToBeak.Size = new System.Drawing.Size(196, 23);
            this.TimeToBeak.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Czas do uznania za przerwę pisania  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 329);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeToBeak);
            this.Controls.Add(this.PathToAplication);
            this.Controls.Add(this.PathAplication);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BreakTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LoadLimits);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.changeFokus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HowMenyError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PathToFile);
            this.Controls.Add(this.PathFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathFile;
        private System.Windows.Forms.Button PathToFile;
        private System.Windows.Forms.TextBox HowMenyError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox changeFokus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button LoadLimits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BreakTime;
        private System.Windows.Forms.Button PathToAplication;
        private System.Windows.Forms.TextBox PathAplication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeToBeak;
        private System.Windows.Forms.Label label6;
    }
}

