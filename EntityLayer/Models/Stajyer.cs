using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Stajyer:BaseEntity
    {
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public string KullaniciAdi { get; set; }    
        public string Sifre {  get; set; }

        //ilişkiler
        public virtual ICollection<Rapor> Raporlar { get; set; }
    }
}
