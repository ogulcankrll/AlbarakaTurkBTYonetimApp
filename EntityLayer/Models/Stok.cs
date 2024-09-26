using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Stok:BaseEntity
    {
        public int UrunID { get; set; }
        public int MevcutMiktar { get; set; }
        //İlişkiler
        public virtual Urun Urun { get; set; }
       
    }
}
