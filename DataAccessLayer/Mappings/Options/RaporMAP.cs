using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class RaporMAP:BaseMAP<Rapor>
    {
        public RaporMAP()
        {
            ToTable("Raporlar");
            Property(s => s.Icerik)
                .IsRequired()
                .HasMaxLength(550);


        }
    }
}
