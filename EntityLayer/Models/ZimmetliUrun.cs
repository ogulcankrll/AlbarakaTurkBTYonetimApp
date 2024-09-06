using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class ZimmetliUrun:BaseEntity
    {
        public int PersonelProfilID { get; set; }
        public int UrunID { get; set; }
        public string Aciklama { get; set; }


        //İlişkiler
        public virtual Urun Urun { get; set; }
        public virtual PersonelProfil PersonelProfil { get; set; }
   
    }
}
