namespace SinemaOtomasyonuProjesi
{
    partial class SeansYonetimiFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblSalon = new System.Windows.Forms.Label();
            this.lblSeansGunu = new System.Windows.Forms.Label();
            this.lblSeansSaati = new System.Windows.Forms.Label();
            this.cmbFilmler = new System.Windows.Forms.ComboBox();
            this.cmbSalonlar = new System.Windows.Forms.ComboBox();
            this.dtpSeansGunu = new System.Windows.Forms.DateTimePicker();
            this.txtSeansSaati = new System.Windows.Forms.TextBox();
            this.btnSeansEkle = new System.Windows.Forms.Button();
            this.btnSeansSil = new System.Windows.Forms.Button();
            this.btnSeansDuzenle = new System.Windows.Forms.Button();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seanslarDGW = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeansGunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeansSaati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seanslarDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblFilm.ForeColor = System.Drawing.Color.White;
            this.lblFilm.Location = new System.Drawing.Point(17, 251);
            this.lblFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(61, 29);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Film:";
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSalon.ForeColor = System.Drawing.Color.White;
            this.lblSalon.Location = new System.Drawing.Point(17, 316);
            this.lblSalon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(74, 29);
            this.lblSalon.TabIndex = 1;
            this.lblSalon.Text = "Salon:";
            // 
            // lblSeansGunu
            // 
            this.lblSeansGunu.AutoSize = true;
            this.lblSeansGunu.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSeansGunu.ForeColor = System.Drawing.Color.White;
            this.lblSeansGunu.Location = new System.Drawing.Point(19, 373);
            this.lblSeansGunu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeansGunu.Name = "lblSeansGunu";
            this.lblSeansGunu.Size = new System.Drawing.Size(135, 29);
            this.lblSeansGunu.TabIndex = 2;
            this.lblSeansGunu.Text = "Seans Günü:";
            // 
            // lblSeansSaati
            // 
            this.lblSeansSaati.AutoSize = true;
            this.lblSeansSaati.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSeansSaati.ForeColor = System.Drawing.Color.White;
            this.lblSeansSaati.Location = new System.Drawing.Point(17, 435);
            this.lblSeansSaati.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeansSaati.Name = "lblSeansSaati";
            this.lblSeansSaati.Size = new System.Drawing.Size(129, 29);
            this.lblSeansSaati.TabIndex = 3;
            this.lblSeansSaati.Text = "Seans Saati:";
            // 
            // cmbFilmler
            // 
            this.cmbFilmler.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbFilmler.FormattingEnabled = true;
            this.cmbFilmler.Location = new System.Drawing.Point(153, 248);
            this.cmbFilmler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilmler.Name = "cmbFilmler";
            this.cmbFilmler.Size = new System.Drawing.Size(298, 37);
            this.cmbFilmler.TabIndex = 5;
            // 
            // cmbSalonlar
            // 
            this.cmbSalonlar.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbSalonlar.FormattingEnabled = true;
            this.cmbSalonlar.Location = new System.Drawing.Point(153, 308);
            this.cmbSalonlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSalonlar.Name = "cmbSalonlar";
            this.cmbSalonlar.Size = new System.Drawing.Size(298, 37);
            this.cmbSalonlar.TabIndex = 6;
            // 
            // dtpSeansGunu
            // 
            this.dtpSeansGunu.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpSeansGunu.Location = new System.Drawing.Point(153, 367);
            this.dtpSeansGunu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpSeansGunu.Name = "dtpSeansGunu";
            this.dtpSeansGunu.Size = new System.Drawing.Size(298, 37);
            this.dtpSeansGunu.TabIndex = 7;
            // 
            // txtSeansSaati
            // 
            this.txtSeansSaati.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSeansSaati.Location = new System.Drawing.Point(153, 432);
            this.txtSeansSaati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSeansSaati.Name = "txtSeansSaati";
            this.txtSeansSaati.Size = new System.Drawing.Size(298, 37);
            this.txtSeansSaati.TabIndex = 8;
            // 
            // btnSeansEkle
            // 
            this.btnSeansEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansEkle.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSeansEkle.ForeColor = System.Drawing.Color.White;
            this.btnSeansEkle.Location = new System.Drawing.Point(153, 479);
            this.btnSeansEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeansEkle.Name = "btnSeansEkle";
            this.btnSeansEkle.Size = new System.Drawing.Size(298, 75);
            this.btnSeansEkle.TabIndex = 9;
            this.btnSeansEkle.Text = "Seans Ekle";
            this.btnSeansEkle.UseVisualStyleBackColor = true;
            this.btnSeansEkle.Click += new System.EventHandler(this.btnSeansEkle_Click);
            // 
            // btnSeansSil
            // 
            this.btnSeansSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansSil.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSeansSil.ForeColor = System.Drawing.Color.White;
            this.btnSeansSil.Location = new System.Drawing.Point(153, 564);
            this.btnSeansSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeansSil.Name = "btnSeansSil";
            this.btnSeansSil.Size = new System.Drawing.Size(298, 75);
            this.btnSeansSil.TabIndex = 10;
            this.btnSeansSil.Text = "Seans Sil";
            this.btnSeansSil.UseVisualStyleBackColor = true;
            this.btnSeansSil.Click += new System.EventHandler(this.btnSeansSil_Click);
            // 
            // btnSeansDuzenle
            // 
            this.btnSeansDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeansDuzenle.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSeansDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnSeansDuzenle.Location = new System.Drawing.Point(153, 649);
            this.btnSeansDuzenle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeansDuzenle.Name = "btnSeansDuzenle";
            this.btnSeansDuzenle.Size = new System.Drawing.Size(298, 75);
            this.btnSeansDuzenle.TabIndex = 11;
            this.btnSeansDuzenle.Text = "Seans Düzenle";
            this.btnSeansDuzenle.UseVisualStyleBackColor = true;
            this.btnSeansDuzenle.Click += new System.EventHandler(this.btnSeansDuzenle_Click);
            // 
            // BtnGeri
            // 
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Calibri", 12F);
            this.BtnGeri.ForeColor = System.Drawing.Color.White;
            this.BtnGeri.Location = new System.Drawing.Point(1154, 181);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(181, 62);
            this.BtnGeri.TabIndex = 13;
            this.BtnGeri.Text = "Menüye Dön";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(426, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 59);
            this.label1.TabIndex = 14;
            this.label1.Text = "Seans Ekle ve Düzenle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seanslar";
            // 
            // seanslarDGW
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seanslarDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.seanslarDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seanslarDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FilmID,
            this.SalonID,
            this.SeansGunu,
            this.SeansSaati});
            this.seanslarDGW.Location = new System.Drawing.Point(479, 251);
            this.seanslarDGW.Name = "seanslarDGW";
            this.seanslarDGW.RowHeadersWidth = 62;
            this.seanslarDGW.RowTemplate.Height = 28;
            this.seanslarDGW.Size = new System.Drawing.Size(856, 473);
            this.seanslarDGW.TabIndex = 16;
            this.seanslarDGW.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seanslarDGW_CellClick);
            this.seanslarDGW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seanslarDGW_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // FilmID
            // 
            this.FilmID.HeaderText = "FilmID";
            this.FilmID.MinimumWidth = 8;
            this.FilmID.Name = "FilmID";
            this.FilmID.Width = 150;
            // 
            // SalonID
            // 
            this.SalonID.HeaderText = "SalonID";
            this.SalonID.MinimumWidth = 8;
            this.SalonID.Name = "SalonID";
            this.SalonID.Width = 150;
            // 
            // SeansGunu
            // 
            this.SeansGunu.HeaderText = "Seans Gunu";
            this.SeansGunu.MinimumWidth = 8;
            this.SeansGunu.Name = "SeansGunu";
            this.SeansGunu.Width = 150;
            // 
            // SeansSaati
            // 
            this.SeansSaati.HeaderText = "Seans Saati";
            this.SeansSaati.MinimumWidth = 8;
            this.SeansSaati.Name = "SeansSaati";
            this.SeansSaati.Width = 150;
            // 
            // SeansYonetimiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1344, 732);
            this.Controls.Add(this.seanslarDGW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.btnSeansDuzenle);
            this.Controls.Add(this.btnSeansSil);
            this.Controls.Add(this.btnSeansEkle);
            this.Controls.Add(this.txtSeansSaati);
            this.Controls.Add(this.dtpSeansGunu);
            this.Controls.Add(this.cmbSalonlar);
            this.Controls.Add(this.cmbFilmler);
            this.Controls.Add(this.lblSeansSaati);
            this.Controls.Add(this.lblSeansGunu);
            this.Controls.Add(this.lblSalon);
            this.Controls.Add(this.lblFilm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SeansYonetimiFormu";
            this.Text = "Seans Ekle ve Düzenle";
            this.Load += new System.EventHandler(this.SeansYonetimiFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seanslarDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblSeansGunu;
        private System.Windows.Forms.Label lblSeansSaati;
        private System.Windows.Forms.ComboBox cmbFilmler;
        private System.Windows.Forms.ComboBox cmbSalonlar;
        private System.Windows.Forms.DateTimePicker dtpSeansGunu;
        private System.Windows.Forms.TextBox txtSeansSaati;
        private System.Windows.Forms.Button btnSeansEkle;
        private System.Windows.Forms.Button btnSeansSil;
        private System.Windows.Forms.Button btnSeansDuzenle;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView seanslarDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeansGunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeansSaati;
    }
}