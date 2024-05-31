
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class kullaniciPanel : Form
    {
        public kullaniciPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kullaniciPanel_Load(object sender, EventArgs e)
        {
            defaultDegerleriDoldur();
        }

        private void defaultDegerleriDoldur()
        {
            combo_yetki.Items.Add("Admin");
            combo_yetki.Items.Add("Kasiyer");
            combo_yetki.SelectedIndex = 0;

            combo_bolge.Items.Add("Adalar");
            combo_bolge.Items.Add("Arnavutköy");
            combo_bolge.Items.Add("Ataşehir");
            combo_bolge.Items.Add("Avcilar");
            combo_bolge.Items.Add("Bağcılar");
            combo_bolge.Items.Add("Bakırköy");
            combo_bolge.Items.Add("Beyoğlu");
            combo_bolge.Items.Add("Çatalca");
            combo_bolge.Items.Add("Çekmeköy");
            combo_bolge.Items.Add("Sancaktepe");
            combo_bolge.SelectedIndex = 0;

            combo_guvenlikSorusu.Items.Add("En Sevdiğiniz Hayvan");
            combo_guvenlikSorusu.Items.Add("En Sevdiğiniz Araba? ");
            combo_guvenlikSorusu.Items.Add("Birinci Sinif öğretmeninizin adı?");
            combo_guvenlikSorusu.Items.Add("Anneniniz kızlık soyadı?");

            combo_guvenlikSorusu.SelectedIndex = 0;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {

        }

        private void combo_bolge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_yetki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_emailAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_guvenlikSorusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_guvenlikCevabi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_kullaniciAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
