using BusinessLogicLayer.GenericRepository;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class KategoriServis
    {
        private readonly KategoriRepository kategoriRepository;

        public KategoriServis()
        {
            kategoriRepository = new KategoriRepository();
        }

        public List<KategoriDTO> KategorileriGetir()
        {
            var kategoriListesi = kategoriRepository.Filtrele(p => p.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi)
                .Select(k=>new KategoriDTO
                {
                    KategoriID = k.ID,
                    KategoriAd=k.KategoriAd,
                }).ToList();
            return kategoriListesi; 

        }

        public void KategoriEkle(Kategori kategori)
        {
            kategoriRepository.Ekle(kategori);
        }

        public Kategori KategoriBul(int id)
        {
            return kategoriRepository.Bul(id);
        }

        public void KategoriSil(int id)
        {
            Kategori kategori = kategoriRepository.Bul(id);
            if (kategori != null)
            {
                kategoriRepository.Sil(kategori);
            }
        }

        public void KategoriGuncelle(Kategori kategori)
        {
            kategoriRepository.Guncelle(kategori);
        }
    }
}
