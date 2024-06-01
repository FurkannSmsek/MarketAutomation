namespace market
{
    partial class SifreDegistirme
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
            this.button_degistir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.text_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.text_yeniSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBox_mailAlani = new System.Windows.Forms.GroupBox();
            this.button_onayla = new System.Windows.Forms.Button();
            this.text_dogrulamaKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_dogrulamaKoduGonder = new System.Windows.Forms.Button();
            this.text_emailadresi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.button_sorgula = new System.Windows.Forms.Button();
            this.text_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.text_kullaniciadi = new System.Windows.Forms.TextBox();
            this.grpBox_sifreDegistirmeAlani = new System.Windows.Forms.GroupBox();
            this.grpBox_mailAlani.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBox_sifreDegistirmeAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_degistir
            // 
            this.button_degistir.Location = new System.Drawing.Point(104, 112);
            this.button_degistir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_degistir.Name = "button_degistir";
            this.button_degistir.Size = new System.Drawing.Size(144, 35);
            this.button_degistir.TabIndex = 2;
            this.button_degistir.Text = "Değiştir";
            this.button_degistir.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Yeni Şifre";
            // 
            // text_yeniSifreTekrar
            // 
            this.text_yeniSifreTekrar.Location = new System.Drawing.Point(104, 81);
            this.text_yeniSifreTekrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_yeniSifreTekrar.Name = "text_yeniSifreTekrar";
            this.text_yeniSifreTekrar.Size = new System.Drawing.Size(145, 20);
            this.text_yeniSifreTekrar.TabIndex = 1;
            // 
            // text_yeniSifre
            // 
            this.text_yeniSifre.Location = new System.Drawing.Point(104, 45);
            this.text_yeniSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_yeniSifre.Name = "text_yeniSifre";
            this.text_yeniSifre.Size = new System.Drawing.Size(145, 20);
            this.text_yeniSifre.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yeni Şifre Tekrar";
            // 
            // grpBox_mailAlani
            // 
            this.grpBox_mailAlani.Controls.Add(this.button_onayla);
            this.grpBox_mailAlani.Controls.Add(this.text_dogrulamaKodu);
            this.grpBox_mailAlani.Controls.Add(this.label4);
            this.grpBox_mailAlani.Controls.Add(this.button_dogrulamaKoduGonder);
            this.grpBox_mailAlani.Controls.Add(this.text_emailadresi);
            this.grpBox_mailAlani.Controls.Add(this.label6);
            this.grpBox_mailAlani.Location = new System.Drawing.Point(264, 10);
            this.grpBox_mailAlani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBox_mailAlani.Name = "grpBox_mailAlani";
            this.grpBox_mailAlani.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBox_mailAlani.Size = new System.Drawing.Size(338, 179);
            this.grpBox_mailAlani.TabIndex = 6;
            this.grpBox_mailAlani.TabStop = false;
            this.grpBox_mailAlani.Text = "Mail Alındı";
            this.grpBox_mailAlani.Enter += new System.EventHandler(this.grpBox_mailAlani_Enter);
            // 
            // button_onayla
            // 
            this.button_onayla.Location = new System.Drawing.Point(104, 141);
            this.button_onayla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_onayla.Name = "button_onayla";
            this.button_onayla.Size = new System.Drawing.Size(144, 32);
            this.button_onayla.TabIndex = 6;
            this.button_onayla.Text = "Onayla";
            this.button_onayla.UseVisualStyleBackColor = true;
            // 
            // text_dogrulamaKodu
            // 
            this.text_dogrulamaKodu.Location = new System.Drawing.Point(104, 119);
            this.text_dogrulamaKodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_dogrulamaKodu.Name = "text_dogrulamaKodu";
            this.text_dogrulamaKodu.Size = new System.Drawing.Size(145, 20);
            this.text_dogrulamaKodu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Doğrulama Kodu";
            // 
            // button_dogrulamaKoduGonder
            // 
            this.button_dogrulamaKoduGonder.Location = new System.Drawing.Point(104, 53);
            this.button_dogrulamaKoduGonder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_dogrulamaKoduGonder.Name = "button_dogrulamaKoduGonder";
            this.button_dogrulamaKoduGonder.Size = new System.Drawing.Size(144, 37);
            this.button_dogrulamaKoduGonder.TabIndex = 3;
            this.button_dogrulamaKoduGonder.Text = "Doğrulama Kodu Gönder";
            this.button_dogrulamaKoduGonder.UseVisualStyleBackColor = true;
            this.button_dogrulamaKoduGonder.Click += new System.EventHandler(this.button_dogrulamaKoduGonder_Click);
            // 
            // text_emailadresi
            // 
            this.text_emailadresi.Location = new System.Drawing.Point(104, 29);
            this.text_emailadresi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_emailadresi.Name = "text_emailadresi";
            this.text_emailadresi.Size = new System.Drawing.Size(145, 20);
            this.text_emailadresi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "E-mail Adresiniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Güvenlik Cevabı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Güvenlik Sorusu";
            // 
            // comboBox_guvenlikSorusu
            // 
            this.comboBox_guvenlikSorusu.FormattingEnabled = true;
            this.comboBox_guvenlikSorusu.Location = new System.Drawing.Point(96, 75);
            this.comboBox_guvenlikSorusu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_guvenlikSorusu.Name = "comboBox_guvenlikSorusu";
            this.comboBox_guvenlikSorusu.Size = new System.Drawing.Size(145, 21);
            this.comboBox_guvenlikSorusu.TabIndex = 1;
            // 
            // button_sorgula
            // 
            this.button_sorgula.Location = new System.Drawing.Point(7, 148);
            this.button_sorgula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_sorgula.Name = "button_sorgula";
            this.button_sorgula.Size = new System.Drawing.Size(233, 35);
            this.button_sorgula.TabIndex = 3;
            this.button_sorgula.Text = "Sorgula";
            this.button_sorgula.UseVisualStyleBackColor = true;
            this.button_sorgula.Click += new System.EventHandler(this.button_sorgula_Click);
            // 
            // text_guvenlikCevabi
            // 
            this.text_guvenlikCevabi.Location = new System.Drawing.Point(96, 99);
            this.text_guvenlikCevabi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_guvenlikCevabi.Name = "text_guvenlikCevabi";
            this.text_guvenlikCevabi.Size = new System.Drawing.Size(145, 20);
            this.text_guvenlikCevabi.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_geri);
            this.groupBox1.Controls.Add(this.button_sorgula);
            this.groupBox1.Controls.Add(this.text_guvenlikCevabi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_guvenlikSorusu);
            this.groupBox1.Controls.Add(this.text_kullaniciadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-2, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik Sorusu ile Değiştir";
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(15, 312);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(56, 19);
            this.btn_geri.TabIndex = 3;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // text_kullaniciadi
            // 
            this.text_kullaniciadi.Location = new System.Drawing.Point(96, 52);
            this.text_kullaniciadi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.text_kullaniciadi.Name = "text_kullaniciadi";
            this.text_kullaniciadi.Size = new System.Drawing.Size(145, 20);
            this.text_kullaniciadi.TabIndex = 0;
            // 
            // grpBox_sifreDegistirmeAlani
            // 
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.button_degistir);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.label7);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.text_yeniSifreTekrar);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.text_yeniSifre);
            this.grpBox_sifreDegistirmeAlani.Controls.Add(this.label5);
            this.grpBox_sifreDegistirmeAlani.Location = new System.Drawing.Point(264, 193);
            this.grpBox_sifreDegistirmeAlani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBox_sifreDegistirmeAlani.Name = "grpBox_sifreDegistirmeAlani";
            this.grpBox_sifreDegistirmeAlani.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBox_sifreDegistirmeAlani.Size = new System.Drawing.Size(338, 162);
            this.grpBox_sifreDegistirmeAlani.TabIndex = 7;
            this.grpBox_sifreDegistirmeAlani.TabStop = false;
            this.grpBox_sifreDegistirmeAlani.Text = "Şifre Değiştirme Alanı";
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.grpBox_mailAlani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBox_sifreDegistirmeAlani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.grpBox_mailAlani.ResumeLayout(false);
            this.grpBox_mailAlani.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox_sifreDegistirmeAlani.ResumeLayout(false);
            this.grpBox_sifreDegistirmeAlani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_degistir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_yeniSifreTekrar;
        private System.Windows.Forms.TextBox text_yeniSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBox_mailAlani;
        private System.Windows.Forms.Button button_onayla;
        private System.Windows.Forms.TextBox text_dogrulamaKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_dogrulamaKoduGonder;
        private System.Windows.Forms.TextBox text_emailadresi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_guvenlikSorusu;
        private System.Windows.Forms.Button button_sorgula;
        private System.Windows.Forms.TextBox text_guvenlikCevabi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_kullaniciadi;
        private System.Windows.Forms.GroupBox grpBox_sifreDegistirmeAlani;
        private System.Windows.Forms.Button btn_geri;
    }
}