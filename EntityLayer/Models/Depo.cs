using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Depo : BaseEntity
    {
        public string DepoAd { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        //İlişkiler
        public virtual ICollection<Stok> Stoklar { get; set; }

        public Depo()
        {
            Stoklar = new HashSet<Stok>();
        }




    }
}
