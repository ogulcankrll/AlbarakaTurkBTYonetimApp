using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Mappings.Options.DepartmanMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.KategoriMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.PersonelProfilMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.StokMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.UrunMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.YoneticiMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.StajyerMAP());
            modelBuilder.Configurations.Add(new Mappings.Options.UrunKonumMap());
            modelBuilder.Configurations.Add(new Mappings.Options.RaporMAP());
            
           


        }

        public DbSet<Departman> Departmanlar { get; set; }  
        public DbSet<UrunKonumBilgi> urunKonumBilgileri { get; set; }
        public DbSet<Kategori> Kategoriler {  get; set; }   
        public DbSet<PersonelProfil> PersonelProfil { get; set; }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Urun> Urunler { get; set; }    
        public DbSet<Yonetici> Yonetici { get; set; }
        public DbSet<Stajyer> Stajyer { get; set; }
        public DbSet<Rapor>Raporlar { get; set; }
        



    

    }
}
