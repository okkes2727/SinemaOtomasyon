namespace SinemaOtomasyonuProjesi
{
    partial class RaporlarFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.biletRaporDGW = new System.Windows.Forms.DataGridView();
            this.btnVeriGuncelle = new System.Windows.Forms.Button();
            this.btnDisaAktar = new System.Windows.Forms.Button();
            this.btnMenuyeDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MusteriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.biletRaporDGW)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(598, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "Raporlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bilet Satış Raporları";
            // 
            // biletRaporDGW
            // 
            this.biletRaporDGW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(42)))), ((int)(((byte)(202)))));
            this.biletRaporDGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.biletRaporDGW.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.biletRaporDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletRaporDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Seans,
            this.MusteriAdi,
            this.KoltukNo,
            this.Fiyat});
            this.biletRaporDGW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.biletRaporDGW.Location = new System.Drawing.Point(20, 200);
            this.biletRaporDGW.Name = "biletRaporDGW";
            this.biletRaporDGW.RowHeadersWidth = 50;
            this.biletRaporDGW.RowTemplate.Height = 28;
            this.biletRaporDGW.Size = new System.Drawing.Size(1065, 626);
            this.biletRaporDGW.TabIndex = 9;
            // 
            // btnVeriGuncelle
            // 
            this.btnVeriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeriGuncelle.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnVeriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnVeriGuncelle.Location = new System.Drawing.Point(1102, 200);
            this.btnVeriGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVeriGuncelle.Name = "btnVeriGuncelle";
            this.btnVeriGuncelle.Size = new System.Drawing.Size(330, 62);
            this.btnVeriGuncelle.TabIndex = 10;
            this.btnVeriGuncelle.Text = "Güncelle";
            this.btnVeriGuncelle.UseVisualStyleBackColor = true;
            this.btnVeriGuncelle.Click += new System.EventHandler(this.btnVeriGuncelle_Click);
            // 
            // btnDisaAktar
            // 
            this.btnDisaAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisaAktar.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnDisaAktar.ForeColor = System.Drawing.Color.White;
            this.btnDisaAktar.Location = new System.Drawing.Point(1102, 272);
            this.btnDisaAktar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisaAktar.Name = "btnDisaAktar";
            this.btnDisaAktar.Size = new System.Drawing.Size(330, 62);
            this.btnDisaAktar.TabIndex = 11;
            this.btnDisaAktar.Text = "Dışa Aktar";
            this.btnDisaAktar.UseVisualStyleBackColor = true;
            this.btnDisaAktar.Click += new System.EventHandler(this.btnDisaAktar_Click);
            // 
            // btnMenuyeDon
            // 
            this.btnMenuyeDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuyeDon.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnMenuyeDon.ForeColor = System.Drawing.Color.White;
            this.btnMenuyeDon.Location = new System.Drawing.Point(1102, 762);
            this.btnMenuyeDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenuyeDon.Name = "btnMenuyeDon";
            this.btnMenuyeDon.Size = new System.Drawing.Size(330, 62);
            this.btnMenuyeDon.TabIndex = 12;
            this.btnMenuyeDon.Text = "Menüye Dön";
            this.btnMenuyeDon.UseVisualStyleBackColor = true;
            this.btnMenuyeDon.Click += new System.EventHandler(this.btnMenuyeDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamGelir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblToplamSatis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1102, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 400);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Raporu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Satış:";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(154, 55);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(25, 29);
            this.lblToplamSatis.TabIndex = 1;
            this.lblToplamSatis.Text = "0";
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(154, 106);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(25, 29);
            this.lblToplamGelir.TabIndex = 3;
            this.lblToplamGelir.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Gelir:";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Seans
            // 
            this.Seans.HeaderText = "Seans";
            this.Seans.MinimumWidth = 8;
            this.Seans.Name = "Seans";
            this.Seans.Width = 150;
            // 
            // MusteriAdi
            // 
            this.MusteriAdi.HeaderText = "Müşteri Adı";
            this.MusteriAdi.MinimumWidth = 8;
            this.MusteriAdi.Name = "MusteriAdi";
            this.MusteriAdi.ReadOnly = true;
            this.MusteriAdi.Width = 150;
            // 
            // KoltukNo
            // 
            this.KoltukNo.HeaderText = "Koltuk No";
            this.KoltukNo.MinimumWidth = 8;
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.ReadOnly = true;
            this.KoltukNo.Width = 150;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.MinimumWidth = 8;
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.ReadOnly = true;
            this.Fiyat.Width = 150;
            // 
            // RaporlarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(52)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1445, 838);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMenuyeDon);
            this.Controls.Add(this.btnDisaAktar);
            this.Controls.Add(this.btnVeriGuncelle);
            this.Controls.Add(this.biletRaporDGW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RaporlarFormu";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletRaporDGW)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView biletRaporDGW;
        private System.Windows.Forms.Button btnVeriGuncelle;
        private System.Windows.Forms.Button btnDisaAktar;
        private System.Windows.Forms.Button btnMenuyeDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seans;
        private System.Windows.Forms.DataGridViewTextBoxColumn MusteriAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
    }
}