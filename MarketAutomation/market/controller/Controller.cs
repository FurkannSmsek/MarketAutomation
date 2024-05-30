using market.dao;
using market.enumaration;
using market.model;
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

        public Controller()
        {

            repository = new Repository();
        }
        public User login(string kullaniciAdi, string sifre)
        {
            User result;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                result = repository.login(kullaniciAdi, sifre);

                return result;
            }
            else
            {
                User user = new User();
                user.status = LoginStatus.eksikParametre;
                return user;
            }
        }

        public Urun urunuGetir(string barkod) {
            if (!string.IsNullOrEmpty(barkod)) {
                return repository.urunuGetir(barkod);
            }
            return null;
        }
    }
}
