namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migGuncelleme : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stoklar", "DepoID", "dbo.Depolar");
            DropIndex("dbo.Stoklar", new[] { "DepoID" });
            DropColumn("dbo.Stoklar", "DepoID");
            DropTable("dbo.Depolar");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Depolar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepoAd = c.String(nullable: false, maxLength: 55),
                        Adres = c.String(nullable: false, maxLength: 65),
                        Aciklama = c.String(maxLength: 200),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Stoklar", "DepoID", c => c.Int(nullable: false));
            CreateIndex("dbo.Stoklar", "DepoID");
            AddForeignKey("dbo.Stoklar", "DepoID", "dbo.Depolar", "ID", cascadeDelete: true);
        }
    }
}
