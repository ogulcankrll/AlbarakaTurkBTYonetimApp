﻿using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mappings.Options
{
    public class StokMAP:BaseMAP<Stok>
    {
        public StokMAP() 
        {
            ToTable("Stoklar");
        }
    }
}
