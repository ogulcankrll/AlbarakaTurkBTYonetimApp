using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class UrunKonumDTO
    {
        public int ID { get; set; }
        public string MarkaModel { get; set; }
        public string SeriNumarasi { get; set; }
        public UrunKonum Konum { get; set; }
        public string PersonelAdSoyad { get; set; } 
        public string PersonelSicilNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
    }
}
