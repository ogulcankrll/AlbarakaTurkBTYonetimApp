using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class UrunKonumBilgi:BaseEntity
    {
        public int UrunID { get; set; } 
        public UrunKonum UrunKonum { get; set; }
        public int? PersonelID { get; set; }
        public string Aciklama {  get; set; }

        //ilişkiler
        public virtual Urun Urun { get; set; }
        public virtual PersonelProfil Personel { get; set; }
    }
}
