using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class ZimmetliUrunMAP:BaseMAP<ZimmetliUrun>
    {
        public ZimmetliUrunMAP()
        {
            ToTable("ZimmetliUrunler");
            Property(p => p.Aciklama)
                .IsOptional()
                .HasMaxLength(150);
                
           

            
        }
    }
}
