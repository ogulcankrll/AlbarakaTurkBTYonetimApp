namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaporFonksiyonu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Raporlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StajyerID = c.Int(nullable: false),
                        Icerik = c.String(),
                        OnaylandiMi = c.Boolean(nullable: false),
                        OnaylayanYoneticiID = c.Int(),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Yoneticis", t => t.OnaylayanYoneticiID)
                .ForeignKey("dbo.Stajyerler", t => t.StajyerID, cascadeDelete: true)
                .Index(t => t.StajyerID)
                .Index(t => t.OnaylayanYoneticiID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Raporlar", "StajyerID", "dbo.Stajyerler");
            DropForeignKey("dbo.Raporlar", "OnaylayanYoneticiID", "dbo.Yoneticis");
            DropIndex("dbo.Raporlar", new[] { "OnaylayanYoneticiID" });
            DropIndex("dbo.Raporlar", new[] { "StajyerID" });
            DropTable("dbo.Raporlar");
        }
    }
}
