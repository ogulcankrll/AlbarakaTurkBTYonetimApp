using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public abstract class BaseMAP<T>:EntityTypeConfiguration<T>where T :BaseEntity
    {
        protected BaseMAP()
        {
            Property(x => x.EklenmeTarihi).HasColumnName("Yaratılma Tarihi");
            Property(x => x.SilinmeTarihi).HasColumnName("Silinme Tarihi");
            Property(x => x.GuncellenmeTarihi).HasColumnName("Guncellenme Tarihi");
            Property(x => x.VeriDurumu).HasColumnName("Veri Durumu");

        }
    }
}
