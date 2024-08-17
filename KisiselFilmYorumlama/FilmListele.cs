using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classProje
{
    public partial class FilmListele : Form
    {
        DataTable dt;

        public FilmListele()
        {
            InitializeComponent();
        }

        private void FilmListele_Load(object sender, EventArgs e)
        {
            // DataGridView'e verileri yükle
            LoadDataIntoDataGridView("E://Film.csv");
        }

        private void LoadDataIntoDataGridView(string filePath)
        {


            try
            {
                dt = new DataTable();
                // CSV dosyasından başlıkları oku ve DataTable'a ekle
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(';');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(';');
                        dt.Rows.Add(rows);
                    }
                }

                // DataGridView'e DataTable'ı bağla
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                // Verileri TextBox ve ComboBox'lara aktar
                txtId.Text = row.Cells["ID"].Value.ToString();
                txtFilmad.Text = row.Cells["FilmAdi"].Value.ToString();
                txtYonetmen.Text = row.Cells["Yonetmen"].Value.ToString();
                txtYil.Text = row.Cells["Yil"].Value.ToString();
                cbxTur.Text = row.Cells["Tur"].Value.ToString();
                txtPuan.Text = row.Cells["Puan"].Value.ToString();
                txtYorum.Text = row.Cells["Yorum"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void WriteDataTableToCsv(DataTable dt, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(";", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(";", fields));
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                int id = int.Parse(txtId.Text);
                DataRow[] rows = dt.Select("ID = " + id);
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];

                    // Film nesnesini oluştur ve verileri güncelle
                    Film film = new Film(txtFilmad.Text, txtYonetmen.Text, int.Parse(txtYil.Text), cbxTur.SelectedItem.ToString(), double.Parse(txtPuan.Text));
                    //film.FilmAd = txtFilmad.Text;
                    //film.Yonetmen = txtYonetmen.Text;
                    //film.Yil = int.Parse(txtYil.Text);
                    //film.Tur = cbxTur.Text;
                    //film.Puan = double.Parse(txtPuan.Text);
                    film.Yorum = txtYorum.Text;


                    // DataGridView'i güncelle
                    row["FilmAdi"] = film.FilmAd;
                    row["Yonetmen"] = film.Yonetmen;
                    row["Yil"] = film.Yil;
                    row["Tur"] = film.Tur;
                    row["Puan"] = film.Puan;
                    row["Yorum"] = film.Yorum;
                    dataGridView1.Refresh();
                    MessageBox.Show("Film güncellendi.");

                    // Güncellenen verileri CSV dosyasına yaz
                    WriteDataTableToCsv(dt, "E://Film.csv");
                }
                else
                {
                    MessageBox.Show("Film bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                int id = int.Parse(txtId.Text);
                DataRow[] rows = dt.Select("ID = " + id);
                if (rows.Length > 0)
                {
                    DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Seçilen satırı sil
                        rows[0].Delete();
                        dataGridView1.Refresh();
                        MessageBox.Show("Film silindi.");

                        // Güncellenen verileri CSV dosyasına yaz
                        WriteDataTableToCsv(dt, "E://Film.csv");
                    }
                }
                else
                {
                    MessageBox.Show("Film bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin.");
            }
        }
    }
}
