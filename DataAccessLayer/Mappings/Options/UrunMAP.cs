using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class UrunMAP:BaseMAP<Urun>
    {
        public UrunMAP()
        {
            ToTable("Urunler");
          
            Property(u => u.UrunAdi)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.MarkaModel)
                .IsRequired()
                .HasMaxLength(100);

            Property(u => u.SeriNumarasi)
                .IsRequired()
                .HasMaxLength(100);

        
        }

    }
}
