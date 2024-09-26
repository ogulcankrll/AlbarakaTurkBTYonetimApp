using BusinessLogicLayer.GenericRepository;
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
    public class StajyerServis
    {
        private readonly StajyerRepository stajyerRepository;

        public StajyerServis()
        {
            stajyerRepository = new StajyerRepository();
        }

        public List<StajyerDTO> StajyerBilgiGetir()
        {
            var stajyerleriListele = stajyerRepository.Filtrele(p => p.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi)
                .Select(s => new StajyerDTO
                {
                    StajyerSicil=s.ID,
                    AdSoyad=s.AdSoyad,
                    TCNo=s.TcNo,
                    KullaniciAdi=s.KullaniciAdi,    
                    Sifre=s.Sifre,
                   

                   
                }).ToList();
           return stajyerleriListele;   

        }

        public void stajyerKayıtGuncelle(Stajyer stajyer)
        {
            stajyerRepository.Guncelle(stajyer);
        }
        public void stajyerKayıtEkle(Stajyer stajyer)
        {
            stajyerRepository.Ekle(stajyer);
        }
        public void stajyerKayıtSil(int id)
        {
            Stajyer stajyer = stajyerRepository.Bul(id);
            stajyerRepository.Sil(stajyer);
        }




    }
}
