namespace SinemaOtomasyonuProjesi
{
    partial class SalonYonetimiFormu
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
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.lblKapasite = new System.Windows.Forms.Label();
            this.txtSalonAdi = new System.Windows.Forms.TextBox();
            this.txtKapasite = new System.Windows.Forms.TextBox();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.btnSalonSil = new System.Windows.Forms.Button();
            this.lvSalonlar = new System.Windows.Forms.ListView();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblSalonAdi.ForeColor = System.Drawing.Color.White;
            this.lblSalonAdi.Location = new System.Drawing.Point(14, 237);
            this.lblSalonAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(112, 29);
            this.lblSalonAdi.TabIndex = 0;
            this.lblSalonAdi.Text = "Salon Adı:";
            // 
            // lblKapasite
            // 
            this.lblKapasite.AutoSize = true;
            this.lblKapasite.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblKapasite.ForeColor = System.Drawing.Color.White;
            this.lblKapasite.Location = new System.Drawing.Point(14, 290);
            this.lblKapasite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKapasite.Name = "lblKapasite";
            this.lblKapasite.Size = new System.Drawing.Size(103, 29);
            this.lblKapasite.TabIndex = 1;
            this.lblKapasite.Text = "Kapasite:";
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSalonAdi.Location = new System.Drawing.Point(176, 239);
            this.txtSalonAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Size = new System.Drawing.Size(246, 37);
            this.txtSalonAdi.TabIndex = 3;
            // 
            // txtKapasite
            // 
            this.txtKapasite.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtKapasite.Location = new System.Drawing.Point(176, 294);
            this.txtKapasite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKapasite.Name = "txtKapasite";
            this.txtKapasite.Size = new System.Drawing.Size(246, 37);
            this.txtKapasite.TabIndex = 4;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.ForeColor = System.Drawing.Color.White;
            this.btnSalonEkle.Location = new System.Drawing.Point(176, 341);
            this.btnSalonEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(246, 75);
            this.btnSalonEkle.TabIndex = 5;
            this.btnSalonEkle.Text = "Salon Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = true;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // btnSalonSil
            // 
            this.btnSalonSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonSil.ForeColor = System.Drawing.Color.White;
            this.btnSalonSil.Location = new System.Drawing.Point(176, 426);
            this.btnSalonSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalonSil.Name = "btnSalonSil";
            this.btnSalonSil.Size = new System.Drawing.Size(246, 75);
            this.btnSalonSil.TabIndex = 6;
            this.btnSalonSil.Text = "Salon Sil";
            this.btnSalonSil.UseVisualStyleBackColor = true;
            this.btnSalonSil.Click += new System.EventHandler(this.btnSalonSil_Click);
            // 
            // lvSalonlar
            // 
            this.lvSalonlar.Font = new System.Drawing.Font("Calibri", 12F);
            this.lvSalonlar.HideSelection = false;
            this.lvSalonlar.Location = new System.Drawing.Point(430, 237);
            this.lvSalonlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvSalonlar.Name = "lvSalonlar";
            this.lvSalonlar.Size = new System.Drawing.Size(458, 398);
            this.lvSalonlar.TabIndex = 8;
            this.lvSalonlar.UseCompatibleStateImageBehavior = false;
            this.lvSalonlar.SelectedIndexChanged += new System.EventHandler(this.lvSalonlar_SelectedIndexChanged);
            // 
            // BtnGeri
            // 
            this.BtnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.ForeColor = System.Drawing.Color.White;
            this.BtnGeri.Location = new System.Drawing.Point(707, 165);
            this.BtnGeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(181, 62);
            this.BtnGeri.TabIndex = 9;
            this.BtnGeri.Text = "Menüye Dön";
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 59);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salon Ekle ve Düzenle";
            // 
            // SalonYonetimiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(896, 643);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.lvSalonlar);
            this.Controls.Add(this.btnSalonSil);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.txtKapasite);
            this.Controls.Add(this.txtSalonAdi);
            this.Controls.Add(this.lblKapasite);
            this.Controls.Add(this.lblSalonAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SalonYonetimiFormu";
            this.Text = "Salon Ekle ve Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.Label lblKapasite;
        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.TextBox txtKapasite;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.Button btnSalonSil;
        private System.Windows.Forms.ListView lvSalonlar;
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label1;
    }
}