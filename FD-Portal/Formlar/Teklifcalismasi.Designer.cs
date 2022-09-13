namespace FD_Portal.Formlar
{
    partial class Teklifcalismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teklifcalismasi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.siparisno = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.Siparisgecilecek = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teklifno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teklifistemetarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isinadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hatve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cncteknikresim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cnctekliftarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnctekliffiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdkesimfiyatı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lzrteknikresim = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lzrtekliftarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lzrfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparisno.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Siparisgecilecek,
            this.teklifno,
            this.teklifistemetarihi,
            this.firmaadi,
            this.isinadi,
            this.hatve,
            this.miktar,
            this.cncteknikresim,
            this.cnctekliftarihi,
            this.cnctekliffiyati,
            this.fdkesimfiyatı,
            this.lzrteknikresim,
            this.lzrtekliftarihi,
            this.lzrfiyat,
            this.aciklama});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1144, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.siparisno);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(1149, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(331, 466);
            this.groupControl1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sipariş Tarihi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // siparisno
            // 
            this.siparisno.Location = new System.Drawing.Point(107, 59);
            this.siparisno.Name = "siparisno";
            this.siparisno.Size = new System.Drawing.Size(171, 20);
            this.siparisno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş No:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(126, 152);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 37);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Sipariş Geç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lütfen Sipariş Geçilecek Teklifi Seçiniz";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(126, 309);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(129, 37);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Sil";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(126, 223);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(129, 37);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Düzenle";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(126, 266);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(129, 37);
            this.simpleButton4.TabIndex = 8;
            this.simpleButton4.Text = "Yenile";
            // 
            // Siparisgecilecek
            // 
            this.Siparisgecilecek.HeaderText = "Sipariş";
            this.Siparisgecilecek.Name = "Siparisgecilecek";
            // 
            // teklifno
            // 
            this.teklifno.HeaderText = "Teklif No:";
            this.teklifno.Name = "teklifno";
            // 
            // teklifistemetarihi
            // 
            this.teklifistemetarihi.HeaderText = "Teklif İsteme Tarihi";
            this.teklifistemetarihi.Name = "teklifistemetarihi";
            this.teklifistemetarihi.Width = 101;
            // 
            // firmaadi
            // 
            this.firmaadi.HeaderText = "Firma Adı";
            this.firmaadi.Name = "firmaadi";
            // 
            // isinadi
            // 
            this.isinadi.HeaderText = "İşin Adı";
            this.isinadi.Name = "isinadi";
            // 
            // hatve
            // 
            this.hatve.HeaderText = "Hatve";
            this.hatve.Name = "hatve";
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Miktar";
            this.miktar.Name = "miktar";
            // 
            // cncteknikresim
            // 
            this.cncteknikresim.HeaderText = "Cnc Teknik Resim";
            this.cncteknikresim.Name = "cncteknikresim";
            // 
            // cnctekliftarihi
            // 
            this.cnctekliftarihi.HeaderText = "Cnc Teklif Tarihi";
            this.cnctekliftarihi.Name = "cnctekliftarihi";
            // 
            // cnctekliffiyati
            // 
            this.cnctekliffiyati.HeaderText = "CNC Fiyatı";
            this.cnctekliffiyati.Name = "cnctekliffiyati";
            // 
            // fdkesimfiyatı
            // 
            this.fdkesimfiyatı.HeaderText = "FD Kesim Fiyatı";
            this.fdkesimfiyatı.Name = "fdkesimfiyatı";
            // 
            // lzrteknikresim
            // 
            this.lzrteknikresim.HeaderText = "LZR Teknik Resim";
            this.lzrteknikresim.Name = "lzrteknikresim";
            // 
            // lzrtekliftarihi
            // 
            this.lzrtekliftarihi.HeaderText = "LZR Teklif Tarihi";
            this.lzrtekliftarihi.Name = "lzrtekliftarihi";
            // 
            // lzrfiyat
            // 
            this.lzrfiyat.HeaderText = "LZR Fiyat";
            this.lzrfiyat.Name = "lzrfiyat";
            // 
            // aciklama
            // 
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.Name = "aciklama";
            // 
            // Teklifcalismasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 481);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Teklifcalismasi";
            this.Text = "Teklifcalismasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparisno.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit siparisno;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Siparisgecilecek;
        private System.Windows.Forms.DataGridViewTextBoxColumn teklifno;
        private System.Windows.Forms.DataGridViewTextBoxColumn teklifistemetarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn isinadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hatve;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewButtonColumn cncteknikresim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnctekliftarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnctekliffiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdkesimfiyatı;
        private System.Windows.Forms.DataGridViewButtonColumn lzrteknikresim;
        private System.Windows.Forms.DataGridViewTextBoxColumn lzrtekliftarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn lzrfiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
    }
}