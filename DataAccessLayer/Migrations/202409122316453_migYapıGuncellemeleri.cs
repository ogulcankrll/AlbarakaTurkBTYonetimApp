namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migYapıGuncellemeleri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stajyerler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdSoyad = c.String(),
                        TcNo = c.String(),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stajyerler");
        }
    }
}
