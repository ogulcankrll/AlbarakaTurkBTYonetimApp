using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class DepoMAP:BaseMAP<Depo>
    {
        public DepoMAP() 
        {
            ToTable("Depolar");
            Property(d => d.DepoAd)
                .IsRequired()
                .HasMaxLength(55);
            Property(d => d.Adres)
                .HasMaxLength(65)
                .IsRequired();
            Property(d => d.Aciklama)
                .IsOptional()
                .HasMaxLength(200);
            

        }
    }
}
