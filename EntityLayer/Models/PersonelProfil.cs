using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class PersonelProfil : BaseEntity
    {
    
        public string SicilNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }
        public string Email { get; set; }
        public string Pozisyon { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime? AyrilmaTarihi { get; set; }
        public int DepartmanID { get; set; }


        // İlişkiler
        public virtual Departman Departman { get; set; }
        public virtual ICollection<ZimmetliUrun> ZimmetlenecekPersonel { get; set; }

        public PersonelProfil()
        {
           
            BaslangicTarihi = DateTime.Now;
            ZimmetlenecekPersonel=new HashSet<ZimmetliUrun>();
        }

    }

}
