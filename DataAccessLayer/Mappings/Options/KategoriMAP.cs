using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class KategoriMAP:BaseMAP<Kategori>
    {
        public KategoriMAP()
        {
            ToTable("Kategoriler");
            
            Property(k => k.KategoriAd)
                .IsRequired()
                .HasMaxLength(50);

            Property(k => k.Aciklama)
                .HasMaxLength(200);

           
        }
    }
}
