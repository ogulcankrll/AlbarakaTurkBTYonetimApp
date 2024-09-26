using BusinessLogicLayer.GenericRepository;
using DataAccessLayer.GenericRepository;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class GirisServis
    {
        private readonly YoneticiRepository yoneticiRepo;
        private readonly StajyerRepository stajyerRepo; 
       

        public GirisServis(YoneticiRepository yoneticiRepository)
        {
            yoneticiRepo = yoneticiRepository;
        }

        public GirisServis(StajyerRepository stajyerRepository)
        {
            stajyerRepo = stajyerRepository;    
        }

        public bool YoneticiGirisi(string kullaniciAdi, string sifre)
        {

           return  yoneticiRepo.HerhangiBiriniKontrolEt(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
           

        }

        public int StajyerGirisi(string kullaniciAdi, string sifre)
        {
            var stajyer = stajyerRepo.IlkVeyaVarsayilan(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            return stajyer != null ? stajyer.ID : -1;
        }

    }
}
