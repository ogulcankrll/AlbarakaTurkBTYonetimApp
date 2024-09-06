using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Kategori:BaseEntity
    {
    
        public string KategoriAd { get; set; }
        public string Aciklama { get; set; }  
      
        //ilişkiler
        public virtual ICollection<Urun> Urunler { get; set; }

        public Kategori()
        {
            Urunler=new HashSet<Urun>(); 
        }
    }
}
