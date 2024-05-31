using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.dao
{
    public class Repository
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int returnvalue;
        public Repository() {

            con = new SqlConnection("Data Source=DESKTOP-C1C9D4M\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True;");



        }
        public void baglantiAyarla() {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            else {
                con.Close();
            }
        }

        public User login(string kullanciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from loginTable where kullaniciAdi=@kulad and sifre=@sifre",con);
            cmd.Parameters.AddWithValue("@kulad",kullanciAdi);
            cmd.Parameters.AddWithValue("@sifre",sifre);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                User user = new User();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciAdi = dr["kullaniciAdi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.emailAdres = dr["emailAdres"].ToString();
                user.guvenlikSorusu = dr["guvenlikSorusu"].ToString();
                user.guvenlikCevabi = dr["guvenlikCevabı"].ToString();
                user.status = LoginStatus.basarili;
                return user;


            }
            else {
                User user = new User();
                user.status = LoginStatus.basarisiz;
                return user;
            }

           
        }

        public Urun urunuGetir(string barkod) {

            con.Open();
            cmd = new SqlCommand("select * from urun where barkodKod=@code",con);
            cmd.Parameters.AddWithValue("@code", barkod);
            dr = cmd.ExecuteReader();
            Urun urun = new Urun();

            while (dr.Read()) {
                
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                urun.olusturmaTarih = DateTime.Parse(dr["olusturulma_Tarih"].ToString());    //hata oldu
                urun.guncellenmeTarih = DateTime.Parse(dr["guncellenme_Tarih"].ToString());   // hata oldu 
                urun.urunIsim=dr["urunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.ciro = int.Parse(dr["ciro"].ToString());   //hata oldu 
            }


            con.Close();

            return urun;
        }
        public List<Urun> tumUrunleriGetir()
        {
            List<Urun> urunList = new List<Urun>();

            con.Open();
            cmd = new SqlCommand("select * from urun", con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Urun urun = new Urun();
                urun.id = dr["id"].ToString();
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodKod = dr["barkodKod"].ToString();
                urun.olusturmaTarih = DateTime.Parse (dr["olusturulma_Tarih"].ToString());
                if (!string.IsNullOrEmpty(dr["guncellenme_Tarih"].ToString()))
                    {
                    urun.guncellenmeTarih = DateTime.Parse(dr["guncellenme_Tarih"].ToString());
                }
                urun.urunIsim = dr["urunIsim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());
                urun.ciro = int.Parse(dr["ciro"].ToString());
                urunList.Add(urun);

            }
            con.Close();
            return urunList;
        }
        public LoginStatus urunEkle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturmaTarih);
            cmd.Parameters.AddWithValue("@guncellenme_Tarih", urun.guncellenmeTarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if(returnvalue==1)
            {
                return LoginStatus.basarili;

            }
            return LoginStatus.basarisiz;
        }
        public LoginStatus urunGuncelle(Urun urun)
        {
            con.Open();
            cmd = new SqlCommand("sp_urunGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", urun.id);
            cmd.Parameters.AddWithValue("@qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("@barkodKod", urun.barkodKod);
            cmd.Parameters.AddWithValue("@olusturulma_Tarih", urun.olusturmaTarih);
            cmd.Parameters.AddWithValue("@guncellenme_Tarih", urun.guncellenmeTarih);
            cmd.Parameters.AddWithValue("@urunIsim", urun.urunIsim);
            cmd.Parameters.AddWithValue("@kilo", urun.kilo);
            cmd.Parameters.AddWithValue("@fiyat", urun.fiyat);
            cmd.Parameters.AddWithValue("@ciro", urun.ciro);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if(returnvalue ==1)
            {
                return LoginStatus.basarili;
            }
            else
            {
                return LoginStatus.basarisiz;
            }
        }
        public LoginStatus urunSil(string id)
        {
            con.Open();
            cmd = new SqlCommand("delete from urun where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if(returnvalue==1)
            {
                return LoginStatus.basarili;
            }
            return LoginStatus.basarisiz;
        }
    }
}
