using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? SilinmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
        public DataStatus VeriDurumu { get; set; }

        public BaseEntity()
        {
            EklenmeTarihi=DateTime.Now; 
            VeriDurumu=DataStatus.Eklendi;
        }
    }
}
