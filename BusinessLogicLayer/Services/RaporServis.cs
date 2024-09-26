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
    public class RaporServis
    {
        RaporRepository RaporRepository;
        public RaporServis() 
        {
           RaporRepository = new RaporRepository();
        }
        public List<RaporDTO> RaporBilgiGetir()
        {
            var raporlarıListele = RaporRepository.Filtrele(p => p.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi)
                .Select(s => new RaporDTO
                {
                    AdSoyad=s.Stajyer.AdSoyad,
                    Icerik=s.Icerik,    
                    YazimTarihi=s.EklenmeTarihi,


                }).ToList();
            return raporlarıListele;

        }
        public void RaporEkle(Rapor rapor)
        {
            RaporRepository.Ekle(rapor);
        }
    }

    




}
