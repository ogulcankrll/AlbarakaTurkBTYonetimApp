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
    public class UrunServis
    {
        private readonly UrunRepository urunRepository;
        public UrunServis()
        {
            urunRepository = new UrunRepository();  
        }

        public List<UrunDTO> UrunBilgileriGetir()
        {

            var personelListesi = urunRepository.Filtrele(p => p.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi)
                .Select(p => new UrunDTO
                {
                    UrunID=p.ID,
                    MarkaModel = p.MarkaModel,  
                    KategoriAdi=p.Kategori.KategoriAd,
                    SeriNo=p.SeriNumarasi,
                    KategoriID = p.KategoriID

                }).ToList();

            return personelListesi;
        }

        public void UrunEkle(Urun urun)
        {
           urunRepository.Ekle(urun);
        }
        public void urunGuncelle(Urun urun)
        {
            urunRepository.Guncelle(urun);
        }
        public void urunSil(int id)
        {
            Urun urun= urunRepository.Bul(id);
            urunRepository.Sil(urun);   
        }

    }
}
