using DataAccessLayer.Context;
using EntityLayer.DTO;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.GenericRepository
{
    public class PersonelProfilRepository : BaseRepository<PersonelProfil>
    {
        public List<PersonelProfilDTO> PersonelVeDepartmanGetir()
        {
          
            var personelListesi = Filtrele(p => p.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi)
                .Select(p => new PersonelProfilDTO
                {
                    ID = p.ID,
                    SicilNo = p.SicilNo,
                    Ad = p.Ad,
                    Soyad = p.Soyad,
                    TelNo = p.TelefonNumarasi,
                    Mail = p.Email,
                    Pozisyon = p.Pozisyon,
                    DepartmanAdi = p.Departman.DepartmanAd
                }).ToList();

            return personelListesi;
        }

        

    }
}
