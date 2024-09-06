using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Urun : BaseEntity
    {
       
        public string UrunAdi { get; set; }
        public string MarkaModel { get; set; }
        public string SeriNumarasi { get; set; }
        public int KategoriID { get; set; }

        // İlişkiler
        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Stok> Stoklar { get; set; }
        public virtual ICollection<ZimmetliUrun>ZimmetliUrun { get; set; }

        public Urun()
        {
            Stoklar=new HashSet<Stok>();
            ZimmetliUrun=new HashSet<ZimmetliUrun>();
        }

    }



}
