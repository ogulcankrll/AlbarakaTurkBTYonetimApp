using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class UrunDTO
    {
        public int UrunID { get; set; } 
        public string MarkaModel { get; set; }
        public string SeriNo { get; set; }
        public string KategoriAdi { get; set; }
        public int KategoriID { get; set; }
      
    }
}
