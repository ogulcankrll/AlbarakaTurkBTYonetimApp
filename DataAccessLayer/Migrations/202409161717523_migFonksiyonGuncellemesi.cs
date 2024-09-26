namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migFonksiyonGuncellemesi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UrunKonumları",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UrunID = c.Int(nullable: false),
                        UrunKonum = c.Int(nullable: false),
                        PersonelID = c.Int(nullable: false),
                        Aciklama = c.String(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonelProfilleri", t => t.PersonelID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.UrunID)
                .Index(t => t.PersonelID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UrunKonumları", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.UrunKonumları", "PersonelID", "dbo.PersonelProfilleri");
            DropIndex("dbo.UrunKonumları", new[] { "PersonelID" });
            DropIndex("dbo.UrunKonumları", new[] { "UrunID" });
            DropTable("dbo.UrunKonumları");
        }
    }
}
