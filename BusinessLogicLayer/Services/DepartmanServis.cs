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
    public class DepartmanServis
    {
        private DepartmanRepository departmanRepository;

        public DepartmanServis()
        {
            departmanRepository = new DepartmanRepository();
        }

        public List<DepartmanDTO> DepartmanlariGetir()
        {
            var departmanListesi = departmanRepository.Filtrele(p => p.VeriDurumu != EntityLayer.Enums.DataStatus.Silindi)
               .Select(d => new DepartmanDTO
                {
                    DepartmanID = d.ID,
                    DepartmanAd = d.DepartmanAd,
                    DepartmanKat = d.DepartmanKat,
                    
                })
                .ToList();
            return departmanListesi;
        }

        public void DepartmanEkle(Departman departman)
        {
            departmanRepository.Ekle(departman);
        }
        public Departman DepartmanBul(int id)
        {
            return departmanRepository.Bul(id);
        }
        public void DepartmanSil(int id)
        {
            Departman departman = departmanRepository.Bul(id);
            departmanRepository.Sil(departman);

        }
        public void DepartmanGuncelle(Departman departman)
        {
            departmanRepository.Guncelle(departman);
        }
       

        
    }
}
