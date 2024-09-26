using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class StajyerMAP:BaseMAP<Stajyer>
    {
        public StajyerMAP()
        {
            ToTable("Stajyerler");
            HasKey(s => s.ID);

            Property(s => s.AdSoyad)
                .IsRequired()
                .HasMaxLength(100);

            Property(s => s.TcNo)
                .IsRequired()
                .HasMaxLength(11);

            Property(s => s.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50);
         
            Property(s => s.Sifre)
                .IsRequired()
                .HasMaxLength(50);

        }

    }
}
