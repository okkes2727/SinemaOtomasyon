using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SinemaOtomasyonuProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //degerleri alıyoruz  adminfile ye deosya yolunu tanımladık
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string adminFilePath = @"./Data/admin.csv";

            bool girisBasarili = false;

            //streamreader kullanarak dosyayı satır satır okuyoruz 
            using (var reader = new StreamReader(adminFilePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (values[1] == kullaniciAdi && values[2] == sifre)
                    {
                        girisBasarili = true;
                        break;
                    }
                }
            }

            //giriş başarılıysa yonetimpaneline yönlendiriyoruz 
            if (girisBasarili)
            {
                SinemaYonetimPaneli sinemaYonetimPaneli = new SinemaYonetimPaneli();
                sinemaYonetimPaneli.Show();
                this.Hide(); //form1 i gizledik
            }
            else
            {
                lblHataMesaji.Visible = true; //HATA MESAJI
            }
        }
    }
}
