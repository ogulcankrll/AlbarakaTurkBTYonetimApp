using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public class Departman:BaseEntity
    {
        public string DepartmanAd{ get; set; }

        //İlişkiler
        public virtual ICollection<PersonelProfil> PersonelProfilleri { get; set; }
        public Departman()
        {
           PersonelProfilleri = new HashSet<PersonelProfil>();
        }




    }
}
