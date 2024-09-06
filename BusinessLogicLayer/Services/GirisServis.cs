using BusinessLogicLayer.GenericRepository;
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
        private readonly KullaniciPersonelRepository personelRepo;

        public GirisServis(YoneticiRepository yoneticiRepository)
        {
            yoneticiRepo = yoneticiRepository;
        }

        public GirisServis(KullaniciPersonelRepository kullaniciPersonelRepository)
        {
            personelRepo = kullaniciPersonelRepository;
            
        }

        public bool YoneticiGirisi(string kullaniciAdi, string sifre)
        {
            var yonetici = yoneticiRepo.IlkVeyaVarsayilan(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            return yonetici != null;
        }

        public bool PersonelGiris(string kullaniciAdi, string sifre)
        {
            var personel = personelRepo.IlkVeyaVarsayilan(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            return personel != null;
        }

    }
}
