using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class YoneticiMAP:BaseMAP<Yonetici>
    {
        public YoneticiMAP()
        {
            Property(y => y.KullaniciAdi)
                .HasMaxLength(20)
                .IsRequired();
            Property(y=>y.Sifre)
                .HasMaxLength (50)
                .IsRequired();
            
           
        }
    }
}
