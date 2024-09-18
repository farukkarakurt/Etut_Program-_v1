namespace Etut_Ders_Kayit_Sistemi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_etutolustur = new System.Windows.Forms.Button();
            this.mask_saat = new System.Windows.Forms.MaskedTextBox();
            this.mask_tarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbo_ogrt = new System.Windows.Forms.ComboBox();
            this.cmbo_Ders = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ogrenci = new System.Windows.Forms.TextBox();
            this.txt_etutid = new System.Windows.Forms.TextBox();
            this.btn_dersiAl = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_dersEkle = new System.Windows.Forms.Button();
            this.txt_dersAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.msk_telno = new System.Windows.Forms.MaskedTextBox();
            this.txt_ogrciMail = new System.Windows.Forms.TextBox();
            this.txt_ogrciSinif = new System.Windows.Forms.TextBox();
            this.txt_ogrcisoyad = new System.Windows.Forms.TextBox();
            this.txt_ogrciad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_fotoekle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_ogtmenAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_ders = new System.Windows.Forms.TextBox();
            this.txt_ogtmenSoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_etutolustur);
            this.groupBox1.Controls.Add(this.mask_saat);
            this.groupBox1.Controls.Add(this.mask_tarih);
            this.groupBox1.Controls.Add(this.cmbo_ogrt);
            this.groupBox1.Controls.Add(this.cmbo_Ders);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_etutolustur
            // 
            this.btn_etutolustur.Location = new System.Drawing.Point(175, 309);
            this.btn_etutolustur.Name = "btn_etutolustur";
            this.btn_etutolustur.Size = new System.Drawing.Size(169, 43);
            this.btn_etutolustur.TabIndex = 4;
            this.btn_etutolustur.Text = "ETÜT OLUŞTUR";
            this.btn_etutolustur.UseVisualStyleBackColor = true;
            this.btn_etutolustur.Click += new System.EventHandler(this.btn_etutolustur_Click);
            // 
            // mask_saat
            // 
            this.mask_saat.Location = new System.Drawing.Point(153, 237);
            this.mask_saat.Mask = "00:00";
            this.mask_saat.Name = "mask_saat";
            this.mask_saat.Size = new System.Drawing.Size(238, 34);
            this.mask_saat.TabIndex = 3;
            this.mask_saat.ValidatingType = typeof(System.DateTime);
            // 
            // mask_tarih
            // 
            this.mask_tarih.Location = new System.Drawing.Point(153, 183);
            this.mask_tarih.Mask = "00/00/0000";
            this.mask_tarih.Name = "mask_tarih";
            this.mask_tarih.Size = new System.Drawing.Size(238, 34);
            this.mask_tarih.TabIndex = 2;
            this.mask_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbo_ogrt
            // 
            this.cmbo_ogrt.FormattingEnabled = true;
            this.cmbo_ogrt.Location = new System.Drawing.Point(153, 114);
            this.cmbo_ogrt.Name = "cmbo_ogrt";
            this.cmbo_ogrt.Size = new System.Drawing.Size(238, 36);
            this.cmbo_ogrt.TabIndex = 1;
            // 
            // cmbo_Ders
            // 
            this.cmbo_Ders.FormattingEnabled = true;
            this.cmbo_Ders.Location = new System.Drawing.Point(153, 54);
            this.cmbo_Ders.Name = "cmbo_Ders";
            this.cmbo_Ders.Size = new System.Drawing.Size(238, 36);
            this.cmbo_Ders.TabIndex = 0;
            this.cmbo_Ders.SelectedIndexChanged += new System.EventHandler(this.cmbo_Ders_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "SAAT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "TARİH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ÖĞRETMEN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "DERS:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ogrenci);
            this.groupBox2.Controls.Add(this.txt_etutid);
            this.groupBox2.Controls.Add(this.btn_dersiAl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(457, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txt_ogrenci
            // 
            this.txt_ogrenci.Location = new System.Drawing.Point(114, 94);
            this.txt_ogrenci.Name = "txt_ogrenci";
            this.txt_ogrenci.Size = new System.Drawing.Size(164, 34);
            this.txt_ogrenci.TabIndex = 1;
            // 
            // txt_etutid
            // 
            this.txt_etutid.Location = new System.Drawing.Point(114, 48);
            this.txt_etutid.Name = "txt_etutid";
            this.txt_etutid.Size = new System.Drawing.Size(164, 34);
            this.txt_etutid.TabIndex = 0;
            // 
            // btn_dersiAl
            // 
            this.btn_dersiAl.Location = new System.Drawing.Point(79, 168);
            this.btn_dersiAl.Name = "btn_dersiAl";
            this.btn_dersiAl.Size = new System.Drawing.Size(169, 43);
            this.btn_dersiAl.TabIndex = 2;
            this.btn_dersiAl.Text = "DERSİ AL";
            this.btn_dersiAl.UseVisualStyleBackColor = true;
            this.btn_dersiAl.Click += new System.EventHandler(this.btn_dersiAl_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "ÖĞRENCİ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "ETÜT ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1101, 317);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1089, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_dersEkle);
            this.groupBox4.Controls.Add(this.txt_dersAdi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(457, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 130);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btn_dersEkle
            // 
            this.btn_dersEkle.Location = new System.Drawing.Point(114, 75);
            this.btn_dersEkle.Name = "btn_dersEkle";
            this.btn_dersEkle.Size = new System.Drawing.Size(164, 40);
            this.btn_dersEkle.TabIndex = 1;
            this.btn_dersEkle.Text = "DERS EKLE";
            this.btn_dersEkle.UseVisualStyleBackColor = true;
            this.btn_dersEkle.Click += new System.EventHandler(this.btn_dersEkle_Click);
            // 
            // txt_dersAdi
            // 
            this.txt_dersAdi.Location = new System.Drawing.Point(114, 35);
            this.txt_dersAdi.Name = "txt_dersAdi";
            this.txt_dersAdi.Size = new System.Drawing.Size(164, 34);
            this.txt_dersAdi.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "DERS ADI:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.msk_telno);
            this.groupBox5.Controls.Add(this.txt_ogrciMail);
            this.groupBox5.Controls.Add(this.txt_ogrciSinif);
            this.groupBox5.Controls.Add(this.txt_ogrcisoyad);
            this.groupBox5.Controls.Add(this.txt_ogrciad);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(779, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 368);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(117, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "ÖĞRENCİ EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // msk_telno
            // 
            this.msk_telno.Location = new System.Drawing.Point(120, 203);
            this.msk_telno.Mask = "(999) 000-0000";
            this.msk_telno.Name = "msk_telno";
            this.msk_telno.Size = new System.Drawing.Size(183, 34);
            this.msk_telno.TabIndex = 3;
            // 
            // txt_ogrciMail
            // 
            this.txt_ogrciMail.Location = new System.Drawing.Point(117, 254);
            this.txt_ogrciMail.Name = "txt_ogrciMail";
            this.txt_ogrciMail.Size = new System.Drawing.Size(186, 34);
            this.txt_ogrciMail.TabIndex = 4;
            // 
            // txt_ogrciSinif
            // 
            this.txt_ogrciSinif.Location = new System.Drawing.Point(118, 150);
            this.txt_ogrciSinif.Name = "txt_ogrciSinif";
            this.txt_ogrciSinif.Size = new System.Drawing.Size(185, 34);
            this.txt_ogrciSinif.TabIndex = 2;
            // 
            // txt_ogrcisoyad
            // 
            this.txt_ogrcisoyad.Location = new System.Drawing.Point(118, 105);
            this.txt_ogrcisoyad.Name = "txt_ogrcisoyad";
            this.txt_ogrcisoyad.Size = new System.Drawing.Size(185, 34);
            this.txt_ogrcisoyad.TabIndex = 1;
            // 
            // txt_ogrciad
            // 
            this.txt_ogrciad.Location = new System.Drawing.Point(120, 56);
            this.txt_ogrciad.Name = "txt_ogrciad";
            this.txt_ogrciad.Size = new System.Drawing.Size(183, 34);
            this.txt_ogrciad.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 28);
            this.label12.TabIndex = 0;
            this.label12.Text = "TEL NO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 28);
            this.label11.TabIndex = 0;
            this.label11.Text = "MAIL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "SINIF:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "SOYAD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "AD:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Btn_fotoekle);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1120, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(324, 368);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // Btn_fotoekle
            // 
            this.Btn_fotoekle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_fotoekle.Location = new System.Drawing.Point(91, 311);
            this.Btn_fotoekle.Name = "Btn_fotoekle";
            this.Btn_fotoekle.Size = new System.Drawing.Size(170, 43);
            this.Btn_fotoekle.TabIndex = 0;
            this.Btn_fotoekle.Text = "FOTOĞRAF EKLE";
            this.Btn_fotoekle.UseVisualStyleBackColor = true;
            this.Btn_fotoekle.Click += new System.EventHandler(this.Btn_fotoekle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.txt_ogtmenAd);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txt_ders);
            this.groupBox7.Controls.Add(this.txt_ogtmenSoyad);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(1120, 387);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(324, 316);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(112, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 43);
            this.button4.TabIndex = 3;
            this.button4.Text = "ÖĞRETMEN EKLE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_ogtmenAd
            // 
            this.txt_ogtmenAd.Location = new System.Drawing.Point(103, 33);
            this.txt_ogtmenAd.Name = "txt_ogtmenAd";
            this.txt_ogtmenAd.Size = new System.Drawing.Size(198, 34);
            this.txt_ogtmenAd.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "AD:";
            // 
            // txt_ders
            // 
            this.txt_ders.Location = new System.Drawing.Point(103, 142);
            this.txt_ders.Name = "txt_ders";
            this.txt_ders.Size = new System.Drawing.Size(198, 34);
            this.txt_ders.TabIndex = 2;
            // 
            // txt_ogtmenSoyad
            // 
            this.txt_ogtmenSoyad.Location = new System.Drawing.Point(103, 84);
            this.txt_ogtmenSoyad.Name = "txt_ogtmenSoyad";
            this.txt_ogtmenSoyad.Size = new System.Drawing.Size(198, 34);
            this.txt_ogtmenSoyad.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "SOYAD:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 28);
            this.label15.TabIndex = 0;
            this.label15.Text = "DERS:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1456, 715);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbo_Ders;
        private System.Windows.Forms.Button btn_etutolustur;
        private System.Windows.Forms.MaskedTextBox mask_saat;
        private System.Windows.Forms.MaskedTextBox mask_tarih;
        private System.Windows.Forms.ComboBox cmbo_ogrt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_dersiAl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_ogrenci;
        private System.Windows.Forms.TextBox txt_etutid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_dersEkle;
        private System.Windows.Forms.TextBox txt_dersAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox msk_telno;
        private System.Windows.Forms.TextBox txt_ogrciMail;
        private System.Windows.Forms.TextBox txt_ogrciSinif;
        private System.Windows.Forms.TextBox txt_ogrcisoyad;
        private System.Windows.Forms.TextBox txt_ogrciad;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button Btn_fotoekle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_ogtmenAd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_ogtmenSoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_ders;
    }
}

