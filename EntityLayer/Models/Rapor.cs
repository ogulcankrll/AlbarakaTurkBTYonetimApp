using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Rapor: BaseEntity
    {
        public int StajyerID { get; set; }
        public string Icerik { get; set; }
 
        // İlişkiler
        public virtual Stajyer Stajyer { get; set; }
       
    }
}
