using market.dao;
using market.enumaration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace market.controller
{
    public class Controller
    {
        Repository repository;

        public Controller() {

            repository = new Repository();
        }
        public LoginStatus login(string kullaniciAdi, string sifre) {

            if (kullaniciAdi != null && sifre != "")
            {
                LoginStatus result = repository.login(kullaniciAdi, sifre);
                return result;
            }
            else {
                return LoginStatus.eksikParametre;
            }
        }
    }
}
