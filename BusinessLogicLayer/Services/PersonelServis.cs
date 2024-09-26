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
    public class PersonelServis
    {
        private PersonelProfilRepository personelProfilRepository;
        public PersonelServis()
        {
            personelProfilRepository = new PersonelProfilRepository();
        }

        public List<PersonelProfilDTO> PersonelDetayGetir()
        {
            return personelProfilRepository.PersonelVeDepartmanGetir();
        }
        public void PersonelEkle(PersonelProfil personel)
        {
            personelProfilRepository.Ekle(personel);
        }
        public PersonelProfil PersonelBul(int id)
        {
            return personelProfilRepository.Bul(id); 
        }
        public void PersonelGuncelle(PersonelProfil personel)
        {
            personelProfilRepository.Guncelle(personel);
        }
        public void PersonelSil(int id)
        {
            PersonelProfil personel = personelProfilRepository.Bul(id);
            personelProfilRepository.Sil(personel);

        }

    }
}
