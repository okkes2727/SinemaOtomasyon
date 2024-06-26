using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonuProjesi
{
    public partial class RaporlarFormu : Form
    {
        public RaporlarFormu()
        {
            InitializeComponent();
        }

        private void RaporlarFormu_Load(object sender, EventArgs e)
        {
            // Read data from '.data/biletler.cvs' and display it in the DataGridView
            string[] lines = System.IO.File.ReadAllLines(@"./Data/biletler.csv");
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                if (columns[0].ToString() == "BiletID")
                {
                    continue;
                }
                else
                {
                    biletRaporDGW.Rows.Add(columns);
                }

            }

            try
            {
                lblToplamGelir.Text = biletRaporDGW.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[4].Value)).ToString() + " TL";
                lblToplamSatis.Text = (biletRaporDGW.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar yüklenirken bir hata oluştu: " + ex.Message, "Raporlar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuyeDon_Click(object sender, EventArgs e)
        {
            SinemaYonetimPaneli sinemaYonetimPaneli = new SinemaYonetimPaneli();
            sinemaYonetimPaneli.Show();
            this.Hide();
        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            biletRaporDGW.Rows.Clear();
            string[] lines = System.IO.File.ReadAllLines(@"./Data/biletler.csv");
            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                if (columns[0].ToString() == "BiletID")
                {
                    continue;
                }
                else
                {
                    biletRaporDGW.Rows.Add(columns);
                }

            }

            try
            {
                lblToplamGelir.Text = biletRaporDGW.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[4].Value)).ToString() + " TL";
                lblToplamSatis.Text = (biletRaporDGW.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raporlar yüklenirken bir hata oluştu: " + ex.Message, "Raporlar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Veriler güncellendi.", "Veri Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDisaAktar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Dosyası|*.csv";
            saveFileDialog.Title = "Raporu Kaydet";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName);
                try
                {
                    for (int i = 0; i < biletRaporDGW.Rows.Count; i++)
                    {
                        string line = "";
                        for (int j = 0; j < biletRaporDGW.Columns.Count; j++)
                        {
                            if (biletRaporDGW.Rows[i].Cells[j].Value != null)
                            {
                                line += biletRaporDGW.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                line += " "; // or whatever you want to do when the cell is null
                            }
                            if (j != biletRaporDGW.Columns.Count - 1)
                            {
                                line += ",";
                            }
                        }
                    
                        sw.WriteLine(line);
                    }
                    MessageBox.Show("Rapor başarıyla dışa aktarıldı.", "Dışa Aktar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rapor dışa aktarılırken bir hata oluştu: " + ex.Message, "Dışa Aktar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }

        }
    }
}
