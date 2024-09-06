using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class KullaniciPersonelMAP:BaseMAP<KullaniciPersonel>
    {
        public KullaniciPersonelMAP()
        {
            ToTable("KullaniciPersoneller");

            Property(k => k.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(20);

            Property(k => k.Sifre)
                .IsRequired()
                .HasMaxLength(35);

            HasOptional(x => x.PersonelProfil)
                .WithRequired(x => x.KullaniciPersonel);

           
                
             

        }
    }
}
