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

        public List<LoginTable> getLoginTable()
        {
           List<LoginTable> loginTableList = repository.getLoginTable();
            return loginTableList;
        }
        public LoginStatus doAuthentication(string kullaniciAdi, string guvenlikSorusu, string guvenlikCevabi)
        {
            if(!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(guvenlikSorusu)&& !string.IsNullOrEmpty(guvenlikCevabi))
            {
              LoginStatus result =  repository.doAuthentication(kullaniciAdi, guvenlikSorusu, guvenlikCevabi);
               if(result == LoginStatus.basarili)
                {
                    return result;
                }
                else
                {
                    return LoginStatus.basarisiz;
                }
            }
            else
            {
               return LoginStatus.eksikParametre;
            }
        }
        public Urun urunuGetir(string barkod) {
            if (!string.IsNullOrEmpty(barkod)) {
                return repository.urunuGetir(barkod);
            }
            return null;
        }
        public List<Urun> tumUrunleriGetir()
        {
            return repository.tumUrunleriGetir();
        }
        public LoginStatus urunEkle(Urun urun)
        {
            if(!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.urunIsim) && !string.IsNullOrEmpty(urun.barkodKod))
                    {
                return repository.urunEkle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public LoginStatus urunGuncelle(Urun urun)
        {
            if (!string.IsNullOrEmpty(urun.id) && !string.IsNullOrEmpty(urun.urunIsim) && !string.IsNullOrEmpty(urun.barkodKod))
            {
                return repository.urunGuncelle(urun);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
        public LoginStatus urunSil(string id)
        {
            if(!string.IsNullOrEmpty(id))
            {
                return repository.urunSil(id);
            }
            else
            {
                return LoginStatus.eksikParametre;
            }
        }
    }
}
