
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.imie = new System.Windows.Forms.TextBox();
            this.dataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.LabelUrodzenie = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wiekNup = new System.Windows.Forms.NumericUpDown();
            this.LabelData = new System.Windows.Forms.Label();
            this.odczytBtn = new System.Windows.Forms.Button();
            this.labelGodzina = new System.Windows.Forms.Label();
            this.teraz = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.zapisBtn = new System.Windows.Forms.Button();
            this.outputRtb = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wiekNup)).BeginInit();
            this.SuspendLayout();
            // 
            // imie
            // 
            this.imie.Location = new System.Drawing.Point(3, 38);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(100, 23);
            this.imie.TabIndex = 0;
            // 
            // dataUrodzenia
            // 
            this.dataUrodzenia.Location = new System.Drawing.Point(3, 160);
            this.dataUrodzenia.MaxDate = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            this.dataUrodzenia.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dataUrodzenia.Name = "dataUrodzenia";
            this.dataUrodzenia.Size = new System.Drawing.Size(210, 23);
            this.dataUrodzenia.TabIndex = 1;
            this.dataUrodzenia.Value = new System.DateTime(2021, 10, 4, 0, 0, 0, 0);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(3, 67);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 23);
            this.nazwisko.TabIndex = 2;
            // 
            // LabelUrodzenie
            // 
            this.LabelUrodzenie.AutoSize = true;
            this.LabelUrodzenie.Location = new System.Drawing.Point(3, 133);
            this.LabelUrodzenie.Name = "LabelUrodzenie";
            this.LabelUrodzenie.Size = new System.Drawing.Size(88, 15);
            this.LabelUrodzenie.TabIndex = 5;
            this.LabelUrodzenie.Text = "data urodzenia:";
            // 
            // wiekNup
            // 
            this.wiekNup.Location = new System.Drawing.Point(3, 96);
            this.wiekNup.Name = "wiekNup";
            this.wiekNup.Size = new System.Drawing.Size(100, 23);
            this.wiekNup.TabIndex = 6;
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Location = new System.Drawing.Point(2, 5);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(37, 15);
            this.LabelData.TabIndex = 8;
            this.LabelData.Text = "Data: ";
            // 
            // odczytBtn
            // 
            this.odczytBtn.Location = new System.Drawing.Point(3, 191);
            this.odczytBtn.Name = "odczytBtn";
            this.odczytBtn.Size = new System.Drawing.Size(102, 52);
            this.odczytBtn.TabIndex = 9;
            this.odczytBtn.Text = "Wypisz dane";
            this.odczytBtn.UseVisualStyleBackColor = true;
            this.odczytBtn.Click += new System.EventHandler(this.odczytBtn_Click);
            // 
            // labelGodzina
            // 
            this.labelGodzina.AutoSize = true;
            this.labelGodzina.Location = new System.Drawing.Point(2, 20);
            this.labelGodzina.Name = "labelGodzina";
            this.labelGodzina.Size = new System.Drawing.Size(56, 15);
            this.labelGodzina.TabIndex = 10;
            this.labelGodzina.Text = "Godzina: ";
            // 
            // teraz
            // 
            this.teraz.Location = new System.Drawing.Point(64, 5);
            this.teraz.Name = "teraz";
            this.teraz.Size = new System.Drawing.Size(27, 23);
            this.teraz.TabIndex = 15;
            this.teraz.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Times New Roman";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 47);
            this.button2.TabIndex = 17;
            this.button2.Text = "Arial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // zapisBtn
            // 
            this.zapisBtn.Location = new System.Drawing.Point(111, 191);
            this.zapisBtn.Name = "zapisBtn";
            this.zapisBtn.Size = new System.Drawing.Size(102, 52);
            this.zapisBtn.TabIndex = 18;
            this.zapisBtn.Text = "Zapisz do pliku";
            this.zapisBtn.UseVisualStyleBackColor = true;
            this.zapisBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputRtb
            // 
            this.outputRtb.Location = new System.Drawing.Point(2, 249);
            this.outputRtb.Name = "outputRtb";
            this.outputRtb.ReadOnly = true;
            this.outputRtb.Size = new System.Drawing.Size(211, 84);
            this.outputRtb.TabIndex = 19;
            this.outputRtb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 394);
            this.Controls.Add(this.outputRtb);
            this.Controls.Add(this.zapisBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teraz);
            this.Controls.Add(this.labelGodzina);
            this.Controls.Add(this.odczytBtn);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.wiekNup);
            this.Controls.Add(this.LabelUrodzenie);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.dataUrodzenia);
            this.Controls.Add(this.imie);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.wiekNup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.DateTimePicker dataUrodzenia;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.Label LabelUrodzenie;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown wiekNup;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.Button odczytBtn;
        private System.Windows.Forms.Label labelGodzina;
        private System.Windows.Forms.DateTimePicker teraz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button zapisBtn;
        private System.Windows.Forms.RichTextBox outputRtb;
    }
}

