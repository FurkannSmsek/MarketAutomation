using market.controller;
using market.enumaration;
using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result= controller.login(txt_kullaniciAdi.Text, txt_Sifre.Text);
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Böyle bir kullanıcı vardır.");
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Böyle bir kullanıcı yoktur.");
            }
            else {
                MessageBox.Show("Eksik parametre girildi.");
            }
        }
    }
}
