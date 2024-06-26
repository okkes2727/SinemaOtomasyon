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

namespace SinemaOtomasyonuProjesi
{

    public partial class SeansYonetimiFormu : Form
    {
        public SeansYonetimiFormu()
        {
            InitializeComponent();
            LoadFilmler();
            LoadSalonlar();
            LoadSeanslar();
        }

        private void LoadFilmler()
        {
            string filmlerFilePath = @"./Data/filmler.csv";
            using (var reader = new StreamReader(filmlerFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    cmbFilmler.Items.Add(new { Text = values[1], Value = values[0] });
                }
            }

            cmbFilmler.DisplayMember = "Text";
            cmbFilmler.ValueMember = "Value";
        }

        private void LoadSalonlar()
        {
            string salonlarFilePath = @"./Data/salonlar.csv";
            using (var reader = new StreamReader(salonlarFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    cmbSalonlar.Items.Add(new { Text = values[1], Value = values[0] });
                }
            }

            cmbSalonlar.DisplayMember = "Text";
            cmbSalonlar.ValueMember = "Value";
        }

        private void LoadSeanslar()
        {
            seanslarDGW.Rows.Clear();

            string seanslarFilePath = @"./Data/seanslar.csv";
            using (var reader = new StreamReader(seanslarFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[0] == "SeansID")
                    {
                        continue;
                    }
                    else
                    {
                        seanslarDGW.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                    }
                }
            }

        }

        private int GetNextSeansID()
        {
            int maxID = 0;
            string seanslarFilePath = @"./Data/seanslar.csv";

            using (var reader = new StreamReader(seanslarFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var values = line.Split(',');
                    if (int.TryParse(values[0], out int id))
                    {
                        if (id > maxID)
                        {
                            maxID = id;
                        }
                    }
                }
            }

            return maxID + 1;
        }

        private void btnSeansEkle_Click(object sender, EventArgs e)
        {
            int seansID = GetNextSeansID();
            string filmID = ((dynamic)cmbFilmler.SelectedItem).Value.ToString();
            string salonID = ((dynamic)cmbSalonlar.SelectedItem).Value.ToString();
            string seansGunu = dtpSeansGunu.Value.ToString("yyyy-MM-dd");
            string seansSaati = txtSeansSaati.Text;
            string seanslarFilePath = @"./Data/seanslar.csv";

            using (var writer = new StreamWriter(seanslarFilePath, true))
            {
                writer.WriteLine($"{seansID},{filmID},{salonID},{seansGunu},{seansSaati}");
            }

            LoadSeanslar();
            CreateKoltuklar(seansID.ToString(), salonID);
            MessageBox.Show("Seans ve koltuklar başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateKoltuklar(string seansID, string salonID)
        {
            string salonlarFilePath = @"./Data/salonlar.csv";
            string koltuklarFilePath = @"./Data/koltuklar.csv";

            int kapasite = 0;
            using (var reader = new StreamReader(salonlarFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[0] == salonID)
                    {
                        kapasite = int.Parse(values[2]);
                        break;
                    }
                }
            }

            using (var writer = new StreamWriter(koltuklarFilePath, true))
            {
                for (int i = 1; i <= kapasite; i++)
                {
                    writer.WriteLine($"{seansID},{i},0"); // 0 = boş, 1 = dolu
                }
            }
        }

        private void btnSeansSil_Click(object sender, EventArgs e)
        {
            try
            {
                string seanslarFilePath = @"./Data/seanslar.csv";
                string seansID = seanslarDGW.SelectedRows[0].Cells[0].Value.ToString();

                var lines = File.ReadAllLines(seanslarFilePath).Where(line => !line.StartsWith(seansID + ","));
                File.WriteAllLines(seanslarFilePath, lines);

                MessageBox.Show("Seans başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSeanslar();
            }catch (Exception ex)
            {
                MessageBox.Show("Lütfen bir seans seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeansDuzenle_Click(object sender, EventArgs e)
        {
            string seanslarFilePath = @"./Data/seanslar.csv";
            string seansID = seanslarDGW.SelectedRows[0].Cells[0].Value.ToString();
            string filmID = ((dynamic)cmbFilmler.SelectedItem).Value.ToString();
            string salonID = ((dynamic)cmbSalonlar.SelectedItem).Value.ToString();
            string seansGunu = dtpSeansGunu.Value.ToString("yyyy-MM-dd");
            string seansSaati = txtSeansSaati.Text;

            var lines = File.ReadAllLines(seanslarFilePath).Where(line => !line.StartsWith(seansID + ","));
            File.WriteAllLines(seanslarFilePath, lines);

            using (var writer = new StreamWriter(seanslarFilePath, true))
            {
                writer.WriteLine($"{seansID},{filmID},{salonID},{seansGunu},{seansSaati}");
            }

            MessageBox.Show("Seans başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSeanslar();

        }
        private void btnGeri_Click(object sender, EventArgs e)
        {
            SinemaYonetimPaneli sinemaYonetimPaneli = new SinemaYonetimPaneli();
            sinemaYonetimPaneli.Show();
            this.Hide();
        }

        private void SeansYonetimiFormu_Load(object sender, EventArgs e)
        {
            // Seans Yönetimi Formu Açıldığında cvs dosyasından seansları çekip datagridview'e(seanslarDGW) yüklüyoruz.
            string seanslarFilePath = @"./Data/seanslar.csv";
            using (var reader = new StreamReader(seanslarFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[0] == "SeansID")
                    {
                        continue;
                    }
                    else
                    {
                        seanslarDGW.Rows.Add(values[0], values[1], values[2], values[3], values[4]);
                    }

                }
            }

            // Seanslar datagridview'inin başlıklarını düzenliyoruz.
            seanslarDGW.Columns[0].HeaderText = "Seans ID";
            seanslarDGW.Columns[1].HeaderText = "Film ID";
            seanslarDGW.Columns[2].HeaderText = "Salon ID";
            seanslarDGW.Columns[3].HeaderText = "Seans Günü";
            seanslarDGW.Columns[4].HeaderText = "Seans Saati";


        }

        private void seanslarDGW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.seanslarDGW.Rows[e.RowIndex];
            cmbFilmler.Text = row.Cells[1].Value.ToString();
            cmbSalonlar.Text = row.Cells[2].Value.ToString();
            dtpSeansGunu.Text = row.Cells[3].Value.ToString();
            txtSeansSaati.Text = row.Cells[4].Value.ToString();

        }

        private void seanslarDGW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.seanslarDGW.Rows[e.RowIndex];
            cmbFilmler.Text = row.Cells[1].Value.ToString();
            cmbSalonlar.Text = row.Cells[2].Value.ToString();
            dtpSeansGunu.Text = row.Cells[3].Value.ToString();
            txtSeansSaati.Text = row.Cells[4].Value.ToString();
        }
    }

}
