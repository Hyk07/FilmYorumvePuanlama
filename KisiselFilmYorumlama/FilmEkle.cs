using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace classProje
{
    public partial class FilmEkle : Form
    {
        public FilmEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            //// Yeni film nesnesini oluştur
            //Film yeniFilm = new Film()
            //{
            //    FilmAd = txtFilmad.Text,
            //    Yonetmen = txtYonetmen.Text,
            //    Yil = int.Parse(txtYil.Text),
            //    Tur = cbxTur.SelectedItem.ToString(),
            //    Puan = double.Parse(txtPuan.Text),
            //    Yorum = txtYorum.Text
            //};

            Film yeniFilm = new Film(txtFilmad.Text, txtYonetmen.Text, int.Parse(txtYil.Text), cbxTur.SelectedItem.ToString(), double.Parse(txtPuan.Text));
            //yeniFilm.FilmAd = txtFilmad.Text;
            //yeniFilm.Yonetmen = txtYonetmen.Text;
            //yeniFilm.Yil = int.Parse(txtYil.Text);
            //yeniFilm.Tur = cbxTur.SelectedItem.ToString();
            //yeniFilm.Puan = double.Parse(txtPuan.Text);
            yeniFilm.Yorum = txtYorum.Text;

            string read = "E://Film.csv";
            string[] lines = File.ReadAllLines(read);

            int lastLineNumber = lines.Length;

            string newLine = $"{lastLineNumber + 1}" + txtId.Text; // Burada textBox1, girilen veriyi tutan TextBox kontrolüdür.

            using (StreamWriter sw = File.AppendText(read))
            {
                sw.Write(newLine + ";");
            }


            StreamWriter add = File.AppendText(read);
            add.Write(yeniFilm.FilmAd + ";");
            add.Write(yeniFilm.Yonetmen + ";");
            add.Write(yeniFilm.Yil + ";");
            add.Write(yeniFilm.Tur + ";");
            add.Write(yeniFilm.Puan + ";");
            add.WriteLine(yeniFilm.Yorum);
            add.Close();
            MessageBox.Show("Film Başarılı bir şekilde eklendi.");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

