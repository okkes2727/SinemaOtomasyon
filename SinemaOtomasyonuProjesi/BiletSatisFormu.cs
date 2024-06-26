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
    public partial class BiletSatisFormu : Form
    {
        // Form başlatılır ve mevcut filmler yüklenir
        public BiletSatisFormu()
        {
            InitializeComponent(); // Form bileşenlerini başlatır
            LoadFilmler(); // Filmleri yükler
        }

        // Filmler.csv dosyasından film bilgilerini okur ve ComboBox'a ekler
        private void LoadFilmler()
        {
            string filmlerFilePath = @"./Data/filmler.csv"; // Dosya yolu
            using (var reader = new StreamReader(filmlerFilePath)) // Dosya okuma işlemi başlatılır
            {
                while (!reader.EndOfStream) // Dosya sonuna kadar okuma işlemi devam eder
                {
                    var line = reader.ReadLine(); // Bir satır okunur
                    var values = line.Split(','); // Satırdaki değerler virgülle ayrılır

                    // ComboBox'a film bilgilerini ekler
                    cmbFilmler.Items.Add(new { Text = values[1], Value = values[0], AfisYolu = values[6] });
                }
            }

            // ComboBox'ta görüntüleme ve değer özellikleri ayarlanır
            cmbFilmler.DisplayMember = "Text"; // ComboBox'ta film adları gösterilir
            cmbFilmler.ValueMember = "Value"; // ComboBox'ta film ID'leri saklanır
        }

        // Kullanıcı bir film seçtiğinde seansları ve film afişini yükler
        private void cmbFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSeanslar(); // Seansları yükler
            LoadFilmAfisi(); // Film afişini yükler
        }

        // Seçilen filmin afiş yolunu alır ve PictureBox'a yükler
        private void LoadFilmAfisi()
        {
            var selectedFilm = (dynamic)cmbFilmler.SelectedItem; // Seçilen film bilgisi alınır
            string afisYolu = selectedFilm.AfisYolu; // Afiş yolu alınır

            if (!string.IsNullOrWhiteSpace(afisYolu) && File.Exists(afisYolu)) // Afiş yolu geçerli mi ve dosya mevcut mu kontrol edilir
            {
                pictureBoxFilmAfisi.SizeMode = PictureBoxSizeMode.StretchImage; // Afişin PictureBox'a sığdırılması ayarlanır
                pictureBoxFilmAfisi.ImageLocation = afisYolu; // Afiş yolu PictureBox'a atanır
            }
            else
            {
                pictureBoxFilmAfisi.Image = null; // Afiş yolu geçerli değilse veya dosya yoksa PictureBox boş bırakılır
            }
        }

        // Seçilen filme ait seansları yükler
        private void LoadSeanslar()
        {
            string seanslarFilePath = @"./Data/seanslar.csv"; // Dosya yolu
            using (var reader = new StreamReader(seanslarFilePath)) // Dosya okuma işlemi başlatılır
            {
                cmbSeanslar.Items.Clear(); // ComboBox temizlenir
                while (!reader.EndOfStream) // Dosya sonuna kadar okuma işlemi devam eder
                {
                    var line = reader.ReadLine(); // Bir satır okunur
                    var values = line.Split(','); // Satırdaki değerler virgülle ayrılır

                    // Seçilen filme ait seanslar ComboBox'a eklenir
                    if (values[1] == ((dynamic)cmbFilmler.SelectedItem).Value.ToString())
                    {
                        cmbSeanslar.Items.Add(new { Text = values[3] + " " + values[4], Value = values[0] });
                    }
                }
            }

            // ComboBox'ta görüntüleme ve değer özellikleri ayarlanır
            cmbSeanslar.DisplayMember = "Text"; // ComboBox'ta seans bilgileri gösterilir
            cmbSeanslar.ValueMember = "Value"; // ComboBox'ta seans ID'leri saklanır
        }

        // Kullanıcı bir seans seçtiğinde koltukları yükler
        private void cmbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadKoltuklar(); // Koltukları yükler
        }

        // Seçilen seansa ait koltukları yükler
        private void LoadKoltuklar()
        {
            string koltuklarFilePath = @"./Data/koltuklar.csv"; // Dosya yolu
            dgvKoltuklar.Rows.Clear(); // DataGridView temizlenir

            // Koltuklar sütunlarının tanımlandığından emin olunur
            if (dgvKoltuklar.Columns.Count == 0)
            {
                dgvKoltuklar.Columns.Add("KoltukNo", "Koltuk No"); // Koltuk No sütunu eklenir
                dgvKoltuklar.Columns.Add("Durum", "Durum"); // Durum sütunu eklenir
            }

            using (var reader = new StreamReader(koltuklarFilePath)) // Dosya okuma işlemi başlatılır
            {
                while (!reader.EndOfStream) // Dosya sonuna kadar okuma işlemi devam eder
                {
                    var line = reader.ReadLine(); // Bir satır okunur
                    var values = line.Split(','); // Satırdaki değerler virgülle ayrılır

                    // Seçilen seansa ait koltuklar DataGridView'e eklenir
                    if (values[0] == ((dynamic)cmbSeanslar.SelectedItem).Value.ToString())
                    {
                        dgvKoltuklar.Rows.Add(values[1], values[2] == "0" ? "Boş" : "Dolu");
                    }
                }
            }
        }

        // Bilet satın alma işlemi
        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            // Eğer hiçbir koltuk seçilmediyse kullanıcıya uyarı verilir
            if (dgvKoltuklar.SelectedCells.Count == 0)
            {
                MessageBox.Show("Lütfen bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Uyarı mesajı gösterilir
                return; // Metoddan çıkılır
            }

            string biletlerFilePath = @"./Data\biletler.csv"; // Biletler dosya yolu
            string koltuklarFilePath = @"./Data/koltuklar.csv"; // Koltuklar dosya yolu
            string seansID = ((dynamic)cmbSeanslar.SelectedItem).Value.ToString(); // Seçilen seans ID'si
            string musteriAdi = txtAdi.Text; // Müşteri adı
            string musteriSoyadi = txtSoyadi.Text; // Müşteri soyadı
            string musteriEmail = txtEmail.Text; // Müşteri email
            string musteriTelefon = txtTelefon.Text; // Müşteri telefon
            string koltukNo = dgvKoltuklar.SelectedCells[0].OwningRow.Cells[0].Value.ToString(); // Seçilen koltuk numarası
            string durum = dgvKoltuklar.SelectedCells[0].OwningRow.Cells[1].Value.ToString(); // Seçilen koltuğun durumu
            string fiyat = txtFiyat.Text; // Bilet fiyatı

            // Koltuk doluysa satış işlemi yapılmaz
            if (durum == "Dolu")
            {
                MessageBox.Show("Bu koltuk zaten dolu. Lütfen başka bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Uyarı mesajı gösterilir
                return; // Metoddan çıkılır
            }

            // Bilet kaydı yapılır
            int biletID = GetNextBiletID(); // Yeni bilet ID'si alınır
            using (var writer = new StreamWriter(biletlerFilePath, true)) // Biletler dosyasına yazma işlemi başlatılır
            {
                writer.WriteLine($"{biletID},{seansID},{musteriAdi},{musteriSoyadi},{musteriEmail},{musteriTelefon},{koltukNo},{fiyat}"); // Yeni bilet bilgileri yazılır
            }

            // Koltuk durumu güncellenir
            string[] koltuklarLines = File.ReadAllLines(koltuklarFilePath); // Koltuklar dosyasındaki tüm satırlar okunur
            using (var writer = new StreamWriter(koltuklarFilePath)) // Koltuklar dosyasına yazma işlemi başlatılır
            {
                foreach (string line in koltuklarLines) // Her bir satır için işlem yapılır
                {
                    var values = line.Split(','); // Satırdaki değerler virgülle ayrılır
                    if (values[0] == seansID && values[1] == koltukNo) // Seçilen seans ve koltuk numarası eşleşirse
                    {
                        writer.WriteLine($"{values[0]},{values[1]},1"); // Koltuk durumu 1 (satıldı) olarak güncellenir
                    }
                    else
                    {
                        writer.WriteLine(line); // Satır olduğu gibi yazılır
                    }
                }
            }

            LoadKoltuklar(); // Koltuklar yeniden yüklenir
            MessageBox.Show("Bilet başarıyla alındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Başarı mesajı gösterilir
        }

        // Bilet iptal işlemi
        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            // Eğer hiçbir koltuk seçilmediyse kullanıcıya uyarı verilir
            if (dgvKoltuklar.SelectedCells.Count == 0)
            {
                MessageBox.Show("Lütfen iptal etmek için bir koltuk seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Uyarı mesajı gösterilir
                return; // Metoddan çıkılır
            }

            // Koltuk iptal işlemi
            string koltuklarFilePath = @"./Data/koltuklar.csv"; // Koltuklar dosya yolu
            string seansID = ((dynamic)cmbSeanslar.SelectedItem).Value.ToString(); // Seçilen seans ID'si
            string koltukNo = dgvKoltuklar.SelectedCells[0].OwningRow.Cells[0].Value.ToString(); // Seçilen koltuk numarası

            // Koltuk durumu güncellenir
            string[] koltuklarLines = File.ReadAllLines(koltuklarFilePath); // Koltuklar dosyasındaki tüm satırlar okunur
            using (var writer = new StreamWriter(koltuklarFilePath)) // Koltuklar dosyasına yazma işlemi başlatılır
            {
                foreach (string line in koltuklarLines) // Her bir satır için işlem yapılır
                {
                    var values = line.Split(','); // Satırdaki değerler virgülle ayrılır
                    if (values[0] == seansID && values[1] == koltukNo) // Seçilen seans ve koltuk numarası eşleşirse
                    {
                        writer.WriteLine($"{values[0]},{values[1]},0"); // Koltuk durumu 0 (boş) olarak güncellenir
                    }
                    else
                    {
                        writer.WriteLine(line); // Satır olduğu gibi yazılır
                    }
                }
            }

            LoadKoltuklar(); // Koltuklar yeniden yüklenir
            MessageBox.Show("Bilet başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // Başarı mesajı gösterilir
        }

        // Yeni bilet ID'si alır
        private int GetNextBiletID()
        {
            int maxID = 0; // Maksimum ID başlangıç değeri
            string biletlerFilePath = @"./Data/biletler.csv"; // Biletler dosya yolu

            using (var reader = new StreamReader(biletlerFilePath)) // Dosya okuma işlemi başlatılır
            {
                while (!reader.EndOfStream) // Dosya sonuna kadar okuma işlemi devam eder
                {
                    var line = reader.ReadLine(); // Bir satır okunur
                    if (string.IsNullOrWhiteSpace(line)) continue; // Boş satırlar atlanır

                    var values = line.Split(','); // Satırdaki değerler virgülle ayrılır
                    if (int.TryParse(values[0], out int id)) // İlk değer ID'ye dönüştürülür
                    {
                        if (id > maxID) // Eğer ID mevcut maksimum ID'den büyükse
                        {
                            maxID = id; // Maksimum ID güncellenir
                        }
                    }
                }
            }

            return maxID + 1; // Yeni bilet ID'si mevcut maksimum ID'nin 1 fazlası olarak döndürülür
        }

        // Geri butonuna tıklanınca ana yönetim paneline döner
        private void btnGeri_Click(object sender, EventArgs e)
        {
            SinemaYonetimPaneli sinemaYonetimPaneli = new SinemaYonetimPaneli(); // Yeni yönetim paneli formu oluşturulur
            sinemaYonetimPaneli.Show(); // Yönetim paneli formu gösterilir
            this.Hide(); // Mevcut form gizlenir
        }

        private void BiletSatisFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
