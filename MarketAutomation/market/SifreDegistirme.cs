using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using market.controller;
using market.model;

namespace market
{
    public partial class SifreDegistirme : Form
    {
        int code;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void grpBox_mailAlani_Enter(object sender, EventArgs e)
        {

        }

        private void button_sorgula_Click(object sender, EventArgs e)
        {

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
            Random rdn = new Random();
            code = rdn.Next(111111,999999);
            MailAddress mailAlan = new MailAddress(text_emailadresi.Text, "Eray Emerce");
            MailAddress mailGonderen = new MailAddress("darkside291@hotmail.com", "Eray Emercee");
            MailMessage mesaj = new MailMessage();
            mesaj.To.Add(mailAlan);
            mesaj.From = mailGonderen;
            mesaj.Subject = "Şifre Değiştirme";
            mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz : " + code;

            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("darkside291@hotmail.com", "!1eR4y+1*2k!#");
            smtp.EnableSsl = true;
            smtp.Send(mesaj);
            MessageBox.Show("Doğrulama Kodu Gönderildi. :)", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void text_emailadresi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_onayla_Click(object sender, EventArgs e)
        {
            if (text_dogrulamaKodu.Text == code.ToString())
            {
                grpBox_sifreDegistirmeAlani.Enabled = true;

            }
        }

        private void button_degistir_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if(text_yeniSifre.Text == text_yeniSifreTekrar.Text)
            {
            Log controller.changePassword(text_kullaniciadi.Text,text_yeniSifre.Text);

            }
            
        }
    }
}
