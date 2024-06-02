using AForge.Video.DirectShow;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace market
{
    public partial class MeyveSebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemTip;

        public MeyveSebzePanel()
        {
           
            InitializeComponent();
            txt_islem.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)//toplama
        {
            islemTip = 1;//artıyı temsil eder 
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_sekiz_Click(object sender, EventArgs e)//çıkarma
        {
            islemTip = 2;//eksiyi temsil eder 
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)  //eşittir
        {
            if (islemTip == 1)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2) {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTip == 3)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }
            else if (islemTip == 4)
            {
                sayi2 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 / sayi2).ToString();
            }
        }

        private void grp_hesapmakinesi_Enter(object sender, EventArgs e)
        {

        }
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        private readonly object result;

        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in fic) {
                cmb_kameraac.Items.Add(camera.Name);
            }
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (txt_islem.Text =="0") {
                txt_islem.Text = "";
            }
            txt_islem.Text += ((Button)sender).Text; 
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Text = "0";
        }

        private void btn_bolme_Click(object sender, EventArgs e)//bölme
        {
            islemTip = 4;//bölmeyi temsil eder 
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_carpma_Click(object sender, EventArgs e)//çarpma
        {
            islemTip = 3;//çarpıyı temsil eder 
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void txt_islem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_geriGel_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text.Length != 0)
            {
                txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            }
            else {
                txt_islem.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString() + ":";
            lbl_dakika.Text = DateTime.Now.Minute.ToString() + ":";
            lbl_saniye.Text = DateTime.Now.Second.ToString();

            if (pctbox_Kamera.Image!=null) {

                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pctbox_Kamera.Image);

                if (result!=null) {
                   textBox1.Text = result.ToString();
                    timer1.Stop();
                
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pctbox_Kamera_Click(object sender, EventArgs e)
        {

        }

        private void btn_kameraAc_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fic[cmb_kameraac.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame;
            vcd.Start();
            timer1.Start();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pctbox_Kamera.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void btn_kameraKapat_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pctbox_Kamera.Image = Image.FromFile("D:\\market\\resimler\\camera.ico.ico");
        }

        private void lbl_saat_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controller.Controller controller = new controller.Controller();
            Urun tUrun = controller.urunuGetir(textBox1.Text);
            lbl_urunisim.Text = tUrun.urunIsim.ToString();
            txt_islem.Text = tUrun.fiyat.ToString();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = "barkod.wav";
            ses.Play();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            KasiyerPanel kasiyer = new KasiyerPanel();
            kasiyer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SutUrunlerPanel sut = new SutUrunlerPanel();
            sut.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaklagilPanel baklagil = new BaklagilPanel();
            baklagil.Show();
            this.Hide();
        }
    }
}
