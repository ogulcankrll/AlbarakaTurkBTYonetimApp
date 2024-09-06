using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class DepartmanMAP:BaseMAP<Departman>
    {
        public DepartmanMAP()
        {
            ToTable("Departmanlar");
           Property(d => d.DepartmanAd)
                .IsRequired()
                .HasMaxLength(70);
           
        }
    }
}
