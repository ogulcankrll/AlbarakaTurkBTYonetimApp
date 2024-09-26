using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Yonetici:BaseEntity
    {
        public string SicilNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        //ilişkiler
        public ICollection<Rapor> OnaylananOnayladigiRaporlar {  get; set; }    

    }
}
