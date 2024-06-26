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

    public partial class FilmYonetimiFormu : Form
    {
        public FilmYonetimiFormu()
        {
            InitializeComponent();
            LoadTurler();
            LoadFilmler();
        }

        private void LoadTurler()
        {
            string turlerFilePath = @"./Data/turler.csv";
            using (var reader = new StreamReader(turlerFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    cmbTur.Items.Add(new { Text = values[1], Value = values[0] });
                }
            }

            cmbTur.DisplayMember = "Text";
            cmbTur.ValueMember = "Value";
        }

        private void LoadFilmler()
        {
            string filmlerFilePath = @"./Data/filmler.csv";
            lvFilmler.Items.Clear();
            using (var reader = new StreamReader(filmlerFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    ListViewItem item = new ListViewItem(values[1]); // Film Adı
                    item.Tag = values[0]; // Film ID
                    lvFilmler.Items.Add(item);
                }
            }
        }

        private int GetNextFilmID()
        {
            int maxID = 0;
            string filmlerFilePath = @"./Data/filmler.csv";

            using (var reader = new StreamReader(filmlerFilePath))
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

        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            int filmID = GetNextFilmID();
            string filmAdi = txtFilmAdi.Text;
            string yonetmen = txtYonetmen.Text;
            string yil = txtYil.Text;
            string sure = txtSure.Text;
            string turID = ((dynamic)cmbTur.SelectedItem).Value.ToString();
            string afisYolu = txtAfisYolu.Text;
            string filmlerFilePath = @"./Data/filmler.csv";

            using (var writer = new StreamWriter(filmlerFilePath, true))
            {
                writer.WriteLine($"{filmID},{filmAdi},{yonetmen},{yil},{turID},{sure},{afisYolu}");
            }

            LoadFilmler();
            MessageBox.Show("Film başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilmSil_Click(object sender, EventArgs e)
        {
            if (lvFilmler.SelectedItems.Count > 0)
            {
                string filmlerFilePath = @"./Data/filmler.csv";
                string selectedFilmID = lvFilmler.SelectedItems[0].Tag.ToString();

                var lines = File.ReadAllLines(filmlerFilePath);
                using (var writer = new StreamWriter(filmlerFilePath))
                {
                    foreach (var line in lines)
                    {
                        if (!line.StartsWith(selectedFilmID))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                LoadFilmler();
                MessageBox.Show("Film başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFilmler.SelectedItems.Count > 0)
            {
                var selectedItem = lvFilmler.SelectedItems[0];
                string selectedFilmID = selectedItem.Tag.ToString();
                string filmlerFilePath = @"./Data/filmler.csv";

                using (var reader = new StreamReader(filmlerFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values[0] == selectedFilmID)
                        {
                            txtFilmAdi.Text = values[1];
                            txtYonetmen.Text = values[2];
                            txtYil.Text = values[3];
                            txtSure.Text = values[5];
                            txtAfisYolu.Text = values[6];

                            foreach (var item in cmbTur.Items)
                            {
                                if (((dynamic)item).Value.ToString() == values[4])
                                {
                                    cmbTur.SelectedItem = item;
                                    break;
                                }
                            }

                            pictureBoxAfis.ImageLocation = txtAfisYolu.Text;
                            break;
                        }
                    }
                }
            }
        }

        private void btnAfisSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtAfisYolu.Text = ofd.FileName;
                pictureBoxAfis.ImageLocation = ofd.FileName;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SinemaYonetimPaneli sinemaYonetimPaneli = new SinemaYonetimPaneli();
            sinemaYonetimPaneli.Show();
            this.Hide();
        }

        private void FilmYonetimiFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
