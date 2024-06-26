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
    public partial class SinemaYonetimPaneli : Form
    {
        public SinemaYonetimPaneli()
        {
            InitializeComponent();
        }

        private void btnBiletSatis_Click(object sender, EventArgs e)
        {
            BiletSatisFormu biletSatisFormu = new BiletSatisFormu();
            biletSatisFormu.Show();
            this.Hide();
        }

        private void btnFilmYonetimi_Click(object sender, EventArgs e)
        {
            FilmYonetimiFormu filmYonetimiFormu = new FilmYonetimiFormu();
            filmYonetimiFormu.Show();
            this.Hide();
        }

        private void btnSeansYonetimi_Click(object sender, EventArgs e)
        {
            SeansYonetimiFormu seansYonetimiFormu = new SeansYonetimiFormu();
            seansYonetimiFormu.Show();
            this.Hide();
        }

        private void btnSalonYonetimi_Click(object sender, EventArgs e)
        {
            SalonYonetimiFormu salonYonetimiFormu = new SalonYonetimiFormu();
            salonYonetimiFormu.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Form1 adminGirisFormu = new Form1();
            adminGirisFormu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporlarFormu raporlarFormu = new RaporlarFormu();
            raporlarFormu.Show();
            this.Hide();
        }
    }
}
