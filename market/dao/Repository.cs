using market.enumaration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            con = new SqlConnection("Data Source=DESKTOP-C1C9D4M\\SQLEXPRESS;Initial Catalog=market;Integrated Security=True;Trust Server Certificate=True");
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

        public LoginStatus login(string kullanciAdi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("login_sp",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciAdi",kullanciAdi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            returnvalue = (int)cmd.ExecuteScalar();
            con.Close();

            if (returnvalue==1) {
                return LoginStatus.basarili;
            }
            else {
                return LoginStatus.basarisiz;
            }
        }
    }
}
