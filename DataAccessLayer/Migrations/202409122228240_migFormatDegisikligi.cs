namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migFormatDegisikligi : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.KullaniciPersoneller");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.KullaniciPersoneller",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SicilNo = c.String(),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 35),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
