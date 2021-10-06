using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetMyCustomFormat();
            labelGodzina.Text = "Aktualna godzina to: " + DateTime.Now.ToString("HH:mm");
            LabelData.Text = "Aktualna data to: " + DateTime.Now.ToString("dd.MM.yyyy");
        }
        public void SetMyCustomFormat()
        {
            dataUrodzenia.Format = DateTimePickerFormat.Custom;
            dataUrodzenia.CustomFormat = "dd.mm.yyyy";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelGodzina.Text = "Aktualna godzina to: " + DateTime.Now.ToString("HH:mm");
        }

        private void odczytBtn_Click(object sender, EventArgs e)
        {
            outputRtb.Text = imie.Text + " " + nazwisko.Text +
                "\n" + wiekNup.Value.ToString() + " lat | " +
                dataUrodzenia.Value.ToString("dd.MM.yyyy");

            outputRtb.Select(imie.Text.Length + 1, nazwisko.Text.Length);
            outputRtb.SelectionFont = new Font(outputRtb.Font, FontStyle.Bold);

            int Lata = Convert.ToInt32(wiekNup.Value);
            int indexDaty = outputRtb.Text.IndexOf("|") + 1;
            outputRtb.Select(indexDaty, 10);
            if (Lata > 17) outputRtb.SelectionColor = Color.Blue;
            else outputRtb.SelectionColor = Color.Green;

            TimeSpan IleLat = teraz.Value - dataUrodzenia.Value;
            DateTime data = new DateTime() + IleLat;
            if (data.Year > Lata + 1) MessageBox.Show("Wiek lub data urodzenia jest niepoprawna");
            else if (data.Year < Lata) MessageBox.Show("Wiek lub data urodzenia jest niepoprawna");
        }

        private void button1_Click(object sender, EventArgs e) //Zmiania czcionki odczytu na Times New Roman
        {
            outputRtb.Font = new Font("Times New Roman", 10, FontStyle.Regular);
            outputRtb.Select(imie.Text.Length + 1, nazwisko.Text.Length);
            outputRtb.SelectionFont = new Font(outputRtb.Font, FontStyle.Bold);


            int Lata = Convert.ToInt32(wiekNup.Value);
            int indexDaty = outputRtb.Text.IndexOf("|") + 2;
            outputRtb.Select(indexDaty, indexDaty + 6);
            if (Lata > 17) outputRtb.SelectionColor = Color.Blue;
            else outputRtb.SelectionColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e) //Zmiania czcionki odczytu na Arial
        {
            outputRtb.Font = new Font("Arial", 10, FontStyle.Regular);
            outputRtb.Select(imie.Text.Length + 1, nazwisko.Text.Length);
            outputRtb.SelectionFont = new Font(outputRtb.Font, FontStyle.Bold);

            int Lata = Convert.ToInt32(wiekNup.Value);
            int indexDaty = outputRtb.Text.IndexOf("|") + 2;
            outputRtb.Select(indexDaty, indexDaty + 6);
            if (Lata > 17) outputRtb.SelectionColor = Color.Blue;
            else outputRtb.SelectionColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e) //zapisywanie pliku
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "*.rtf";
            saveDialog.Filter = "RTF Files|*.rtf";
            if (saveDialog.ShowDialog() == DialogResult.OK)
                outputRtb.SaveFile(saveDialog.FileName, RichTextBoxStreamType.RichText);
        }
    }
}