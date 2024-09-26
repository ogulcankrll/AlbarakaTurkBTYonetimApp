using EntityLayer.Enums;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class UrunKonumMap:BaseMAP<UrunKonumBilgi>
    {
        public UrunKonumMap()
        {
            ToTable("UrunKonumları");
            Property(u => u.Aciklama)
                .IsOptional()
                .HasMaxLength(300);
        }
    }
}
