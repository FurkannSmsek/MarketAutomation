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

            con = new SqlConnection("Data Source=DESKTOP-C1C9D4M\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True;TrustServerCertificate=True");



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
    }
}
