namespace SinemaOtomasyonuProjesi
{
    partial class BiletSatisFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFilmler = new System.Windows.Forms.Label();
            this.lblSeanslar = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbFilmler = new System.Windows.Forms.ComboBox();
            this.cmbSeanslar = new System.Windows.Forms.ComboBox();
            this.dgvKoltuklar = new System.Windows.Forms.DataGridView();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.pictureBoxFilmAfisi = new System.Windows.Forms.PictureBox();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltuklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilmAfisi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilmler
            // 
            this.lblFilmler.AutoSize = true;
            this.lblFilmler.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblFilmler.ForeColor = System.Drawing.Color.White;
            this.lblFilmler.Location = new System.Drawing.Point(18, 79);
            this.lblFilmler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilmler.Name = "lblFilmler";
            this.lblFilmler.Size = new System.Drawing.Size(87, 29);
            this.lblFilmler.TabIndex = 0;
            this.lblFilmler.Text = "Filmler:";
            // 
            // lblSeanslar
            // 
            this.lblSeanslar.AutoSize = true;
            this.lblSeanslar.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSeanslar.ForeColor = System.Drawing.Color.White;
            this.lblSeanslar.Location = new System.Drawing.Point(21, 134);
            this.lblSeanslar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeanslar.Name = "lblSeanslar";
            this.lblSeanslar.Size = new System.Drawing.Size(102, 29);
            this.lblSeanslar.TabIndex = 1;
            this.lblSeanslar.Text = "Seanslar:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblAdi.ForeColor = System.Drawing.Color.White;
            this.lblAdi.Location = new System.Drawing.Point(418, 305);
            this.lblAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(52, 29);
            this.lblAdi.TabIndex = 2;
            this.lblAdi.Text = "Adı:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSoyadi.ForeColor = System.Drawing.Color.White;
            this.lblSoyadi.Location = new System.Drawing.Point(418, 388);
            this.lblSoyadi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(85, 29);
            this.lblSoyadi.TabIndex = 3;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(418, 495);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 29);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // cmbFilmler
            // 
            this.cmbFilmler.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbFilmler.FormattingEnabled = true;
            this.cmbFilmler.Location = new System.Drawing.Point(141, 81);
            this.cmbFilmler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilmler.Name = "cmbFilmler";
            this.cmbFilmler.Size = new System.Drawing.Size(266, 37);
            this.cmbFilmler.TabIndex = 5;
            this.cmbFilmler.SelectedIndexChanged += new System.EventHandler(this.cmbFilmler_SelectedIndexChanged);
            // 
            // cmbSeanslar
            // 
            this.cmbSeanslar.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbSeanslar.FormattingEnabled = true;
            this.cmbSeanslar.Location = new System.Drawing.Point(141, 138);
            this.cmbSeanslar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSeanslar.Name = "cmbSeanslar";
            this.cmbSeanslar.Size = new System.Drawing.Size(266, 37);
            this.cmbSeanslar.TabIndex = 6;
            this.cmbSeanslar.SelectedIndexChanged += new System.EventHandler(this.cmbSeanslar_SelectedIndexChanged);
            // 
            // dgvKoltuklar
            // 
            this.dgvKoltuklar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(42)))), ((int)(((byte)(202)))));
            this.dgvKoltuklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKoltuklar.Location = new System.Drawing.Point(6, 260);
            this.dgvKoltuklar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKoltuklar.Name = "dgvKoltuklar";
            this.dgvKoltuklar.RowHeadersWidth = 51;
            this.dgvKoltuklar.Size = new System.Drawing.Size(402, 620);
            this.dgvKoltuklar.TabIndex = 7;
            // 
            // txtAdi
            // 
            this.txtAdi.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtAdi.Location = new System.Drawing.Point(506, 295);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(185, 37);
            this.txtAdi.TabIndex = 8;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSoyadi.Location = new System.Drawing.Point(506, 378);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(185, 37);
            this.txtSoyadi.TabIndex = 9;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFiyat.Location = new System.Drawing.Point(506, 669);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(185, 37);
            this.txtFiyat.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtEmail.Location = new System.Drawing.Point(506, 475);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 37);
            this.txtEmail.TabIndex = 12;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblFiyat.ForeColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(418, 679);
            this.lblFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(67, 29);
            this.lblFiyat.TabIndex = 14;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefon.ForeColor = System.Drawing.Color.White;
            this.lblTelefon.Location = new System.Drawing.Point(416, 582);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(91, 29);
            this.lblTelefon.TabIndex = 13;
            this.lblTelefon.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtTelefon.Location = new System.Drawing.Point(506, 572);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(185, 37);
            this.txtTelefon.TabIndex = 15;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatinAl.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSatinAl.ForeColor = System.Drawing.Color.White;
            this.btnSatinAl.Location = new System.Drawing.Point(423, 732);
            this.btnSatinAl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(269, 66);
            this.btnSatinAl.TabIndex = 16;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptalEt.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnIptalEt.ForeColor = System.Drawing.Color.White;
            this.btnIptalEt.Location = new System.Drawing.Point(423, 814);
            this.btnIptalEt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(269, 66);
            this.btnIptalEt.TabIndex = 17;
            this.btnIptalEt.Text = "İptal Et";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // pictureBoxFilmAfisi
            // 
            this.pictureBoxFilmAfisi.Location = new System.Drawing.Point(701, 260);
            this.pictureBoxFilmAfisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxFilmAfisi.Name = "pictureBoxFilmAfisi";
            this.pictureBoxFilmAfisi.Size = new System.Drawing.Size(433, 620);
            this.pictureBoxFilmAfisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilmAfisi.TabIndex = 18;
            this.pictureBoxFilmAfisi.TabStop = false;
            // 
            // BtnGeri
            // 
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Calibri", 12F);
            this.BtnGeri.ForeColor = System.Drawing.Color.White;
            this.BtnGeri.Location = new System.Drawing.Point(924, 16);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(210, 60);
            this.BtnGeri.TabIndex = 19;
            this.BtnGeri.Text = "Menüye Dön";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 59);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bilet Satış";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(416, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Müşteri Bilgileri";
            // 
            // BiletSatisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1151, 900);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.pictureBoxFilmAfisi);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.dgvKoltuklar);
            this.Controls.Add(this.cmbSeanslar);
            this.Controls.Add(this.cmbFilmler);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblSeanslar);
            this.Controls.Add(this.lblFilmler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BiletSatisFormu";
            this.Text = "Bilet Satış";
            this.Load += new System.EventHandler(this.BiletSatisFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltuklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilmAfisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilmler;
        private System.Windows.Forms.Label lblSeanslar;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbFilmler;
        private System.Windows.Forms.ComboBox cmbSeanslar;
        private System.Windows.Forms.DataGridView dgvKoltuklar;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.PictureBox pictureBoxFilmAfisi;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}