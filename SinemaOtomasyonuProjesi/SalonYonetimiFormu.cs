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
    public partial class SalonYonetimiFormu : Form
    {
        public SalonYonetimiFormu()
        {
            InitializeComponent();
            LoadSalonlar();
        }

        private void LoadSalonlar()
        {
            string salonlarFilePath = @"./Data/salonlar.csv";
            lvSalonlar.Items.Clear();
            using (var reader = new StreamReader(salonlarFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    ListViewItem item = new ListViewItem(values[1]); // Salon Adı
                    item.Tag = values[0]; // Salon ID
                    lvSalonlar.Items.Add(item);
                }
            }
        }

        private int GetNextSalonID()
        {
            int maxID = 0;
            string salonlarFilePath = @"./Data/salonlar.csv";

            using (var reader = new StreamReader(salonlarFilePath))
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

        private void btnSalonEkle_Click(object sender, EventArgs e)
        {
            int salonID = GetNextSalonID();
            string salonAdi = txtSalonAdi.Text;
            string kapasite = txtKapasite.Text;
            string salonlarFilePath = @"./Data/salonlar.csv";

            using (var writer = new StreamWriter(salonlarFilePath, true))
            {
                writer.WriteLine($"{salonID},{salonAdi},{kapasite}");
            }

            LoadSalonlar();
            MessageBox.Show("Salon başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalonSil_Click(object sender, EventArgs e)
        {
            if (lvSalonlar.SelectedItems.Count > 0)
            {
                string salonlarFilePath = @"./Data/salonlar.csv";
                string selectedSalonID = lvSalonlar.SelectedItems[0].Tag.ToString();

                var lines = File.ReadAllLines(salonlarFilePath);
                using (var writer = new StreamWriter(salonlarFilePath))
                {
                    foreach (var line in lines)
                    {
                        if (!line.StartsWith(selectedSalonID))
                        {
                            writer.WriteLine(line);
                        }
                    }
                }

                LoadSalonlar();
                MessageBox.Show("Salon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvSalonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSalonlar.SelectedItems.Count > 0)
            {
                var selectedItem = lvSalonlar.SelectedItems[0];
                string selectedSalonID = selectedItem.Tag.ToString();
                string salonlarFilePath = @"./Data/salonlar.csv";

                using (var reader = new StreamReader(salonlarFilePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values[0] == selectedSalonID)
                        {
                            txtSalonAdi.Text = values[1];
                            txtKapasite.Text = values[2];
                            break;
                        }
                    }
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            SinemaYonetimPaneli sinemaYonetimPaneli = new SinemaYonetimPaneli();
            sinemaYonetimPaneli.Show();
            this.Hide();
        }
    }
}
