using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using market.controller;
using market.enumaration;
using market.model;

namespace market
{
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void grpBox_mailAlani_Enter(object sender, EventArgs e)
        {

        }

        private void button_sorgula_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result = controller.doAuthentication(text_kullaniciadi.Text.Trim().ToLower(), comboBox_guvenlikSorusu.SelectedItem.ToString(), text_guvenlikCevabi.Text) ;

            if(result == LoginStatus.basarili)
            {
                grpBox_mailAlani.Enabled = true;
            }else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiğiniz bilgiler yanlıştır!","Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler Eksiktir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            List<LoginTable> loginTableList = controller.getLoginTable();
            grpBox_mailAlani.Enabled = false;
            grpBox_sifreDegistirmeAlani.Enabled = false;
            
            foreach(LoginTable lt in loginTableList)
            {
                comboBox_guvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button_dogrulamaKoduGonder_Click(object sender, EventArgs e)
        {

        }
    }
}
