using DataAccessLayer.GenericRepository;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class UrunKonumServis
    {
        private readonly UrunKonumRepository urunKonumRepository;

        public UrunKonumServis()
        {
            urunKonumRepository = new UrunKonumRepository();
        }

        public List<UrunKonumDTO> UrunKonumlariGetir()
        {
            return urunKonumRepository.TumunuGetir()
              .Select(k => new UrunKonumDTO
              {
                  ID = k.ID,
                  MarkaModel = k.Urun?.MarkaModel,
                  SeriNumarasi = k.Urun?.SeriNumarasi,
                  Konum = k.UrunKonum, 
                  EklenmeTarihi = k.EklenmeTarihi,
                  GuncellenmeTarihi = k.GuncellenmeTarihi,
                  PersonelAdSoyad = k.Personel != null ? $"{k.Personel.Ad} {k.Personel.Soyad}" : "------------",
                  PersonelSicilNo = k.Personel != null ? k.Personel.SicilNo : "------------",
                  Aciklama = k.Aciklama ?? "------------",
              })
              .ToList();
        }

        public void UrunKonumGuncelle(UrunKonumBilgi urunKonum)
        {
            urunKonumRepository.Guncelle(urunKonum);
        }

        public void UrunKonumEkle(UrunKonumBilgi urunKonum)
        {
            urunKonumRepository.Ekle(urunKonum);
        }
    }

}
