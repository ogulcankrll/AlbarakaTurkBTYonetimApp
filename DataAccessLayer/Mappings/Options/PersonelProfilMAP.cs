using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class PersonelProfilMAP:BaseMAP<PersonelProfil>
    {
        public PersonelProfilMAP()
        {
            ToTable("PersonelProfilleri");

           

            Property(p => p.SicilNo)
                .IsRequired()
                .HasMaxLength(25);

            Property(p => p.Ad)
                .IsRequired()
                .HasMaxLength(25);

            Property(p => p.Soyad)
                .IsRequired()
                .HasMaxLength(20);

            Property(p => p.TelefonNumarasi)
                .HasMaxLength(20);

            Property(p => p.Email)
                .HasMaxLength(70);

            Property(p => p.Pozisyon)
                .HasMaxLength(30);

            Property(p => p.BaslangicTarihi)
                .IsRequired();

            Property(p => p.AyrilmaTarihi)
                .IsOptional();

            



        }
    }
}
