namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigYapıDegisikigi : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ZimmetliUrunler", "PersonelProfilID", "dbo.PersonelProfilleri");
            DropForeignKey("dbo.ZimmetliUrunler", "UrunID", "dbo.Urunler");
            DropIndex("dbo.ZimmetliUrunler", new[] { "PersonelProfilID" });
            DropIndex("dbo.ZimmetliUrunler", new[] { "UrunID" });
            DropTable("dbo.ZimmetliUrunler");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ZimmetliUrunler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonelProfilID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 150),
                        urunDurumu = c.Int(nullable: false),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.ZimmetliUrunler", "UrunID");
            CreateIndex("dbo.ZimmetliUrunler", "PersonelProfilID");
            AddForeignKey("dbo.ZimmetliUrunler", "UrunID", "dbo.Urunler", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ZimmetliUrunler", "PersonelProfilID", "dbo.PersonelProfilleri", "ID", cascadeDelete: true);
        }
    }
}
