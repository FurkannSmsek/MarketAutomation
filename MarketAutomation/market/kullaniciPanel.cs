
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
    }
}
