using market.enumaration;
using market.model;
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
    public partial class UrunPanel : Form
    {
        controller.Controller controller = new controller.Controller();
        public UrunPanel()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            defaultAlanlariDoldur();
            //tumUrunleriGetir();
        }
        public void defaultAlanlariDoldur()
        {
            combo_urunIsim.Items.Add("Brokoli");
            combo_urunIsim.Items.Add("Çilek");
            combo_urunIsim.Items.Add("Elma");
            combo_urunIsim.Items.Add("Lahana");
            combo_urunIsim.Items.Add("Muz");
            combo_urunIsim.Items.Add("Portakal");
            combo_urunIsim.Items.Add("Üzüm");


        }
        public void tumUrunleriGetir()
        {
           dataGridView1.DataSource = controller.tumUrunleriGetir();
        }

        private void btn_kayitEkle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_qrkod.Text;
            urun.barkodKod = txt_barkodKod.Text;
            urun.olusturmaTarih = datetime_olusturmaTarih.Value;
            urun.guncellenmeTarih = datetime_guncellemeTarih.Value;
            urun.urunIsim = combo_urunIsim.SelectedItem.ToString();
            urun.kilo = int.Parse(txt_kilo.Text);
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.ciro = int.Parse(txt_ciro.Text);
            LoginStatus sonuc = controller.urunEkle(urun);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Eklendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
            }
            else if(sonuc==LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Eklenemedi :(", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_kayitGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_qrkod.Text;
            urun.barkodKod = txt_barkodKod.Text;
            urun.olusturmaTarih = datetime_olusturmaTarih.Value;
            urun.guncellenmeTarih = datetime_guncellemeTarih.Value;
            urun.urunIsim = combo_urunIsim.SelectedItem.ToString();
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.kilo = int.Parse(txt_kilo.Text);
            urun.ciro = int.Parse(txt_ciro.Text);

            LoginStatus sonuc = controller.urunGuncelle(urun);
            if (sonuc == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Güncellendi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
            }
            else if (sonuc == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Güncellenemedi :(", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Gerekli Alanları Doldurun !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_qrkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_barkodKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            datetime_olusturmaTarih.Value = DateTime.Parse (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if(!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
            {
                datetime_guncellemeTarih.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }
            combo_urunIsim.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_ciro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kayitSil_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_id.Text))
            {
             LoginStatus sonuc = controller.urunSil(txt_id.Text);
                if(sonuc==LoginStatus.basarili)
                {
                    MessageBox.Show("Kayıt Silindi :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = controller.tumUrunleriGetir();
                }
                else
                {
                    MessageBox.Show("Silmek istediğiniz ürünün id'sini giriniz!", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id'sini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_geri_Click(object sender, EventArgs e)
        {

        }
    }
}
