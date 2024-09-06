namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departmanlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmanAd = c.String(nullable: false, maxLength: 70),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PersonelProfilleri",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        SicilNo = c.String(nullable: false, maxLength: 25),
                        Ad = c.String(nullable: false, maxLength: 25),
                        Soyad = c.String(nullable: false, maxLength: 20),
                        TelefonNumarasi = c.String(maxLength: 20),
                        Email = c.String(maxLength: 70),
                        Pozisyon = c.String(maxLength: 30),
                        BaslangicTarihi = c.DateTime(nullable: false),
                        AyrilmaTarihi = c.DateTime(),
                        DepartmanID = c.Int(nullable: false),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Departmanlar", t => t.DepartmanID, cascadeDelete: true)
                .ForeignKey("dbo.KullaniciPersoneller", t => t.ID)
                .ForeignKey("dbo.Yoneticis", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.DepartmanID);
            
            CreateTable(
                "dbo.KullaniciPersoneller",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 35),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Yoneticis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(nullable: false, maxLength: 20),
                        Sifre = c.String(nullable: false, maxLength: 25),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ZimmetliUrunler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonelProfilID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        Aciklama = c.String(maxLength: 150),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PersonelProfilleri", t => t.PersonelProfilID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.PersonelProfilID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 100),
                        MarkaModel = c.String(nullable: false, maxLength: 100),
                        SeriNumarasi = c.String(nullable: false, maxLength: 100),
                        KategoriID = c.Int(nullable: false),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(nullable: false, maxLength: 50),
                        Aciklama = c.String(maxLength: 200),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stoklar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UrunID = c.Int(nullable: false),
                        DepoID = c.Int(nullable: false),
                        MevcutMiktar = c.Int(nullable: false),
                        YaratılmaTarihi = c.DateTime(name: "Yaratılma Tarihi", nullable: false),
                        SilinmeTarihi = c.DateTime(name: "Silinme Tarihi"),
                        GuncellenmeTarihi = c.DateTime(name: "Guncellenme Tarihi"),
                        VeriDurumu = c.Int(name: "Veri Durumu", nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Depolar", t => t.DepoID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.UrunID)
                .Index(t => t.DepoID);
            
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZimmetliUrunler", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.Stoklar", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.Stoklar", "DepoID", "dbo.Depolar");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropForeignKey("dbo.ZimmetliUrunler", "PersonelProfilID", "dbo.PersonelProfilleri");
            DropForeignKey("dbo.PersonelProfilleri", "ID", "dbo.Yoneticis");
            DropForeignKey("dbo.PersonelProfilleri", "ID", "dbo.KullaniciPersoneller");
            DropForeignKey("dbo.PersonelProfilleri", "DepartmanID", "dbo.Departmanlar");
            DropIndex("dbo.Stoklar", new[] { "DepoID" });
            DropIndex("dbo.Stoklar", new[] { "UrunID" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropIndex("dbo.ZimmetliUrunler", new[] { "UrunID" });
            DropIndex("dbo.ZimmetliUrunler", new[] { "PersonelProfilID" });
            DropIndex("dbo.PersonelProfilleri", new[] { "DepartmanID" });
            DropIndex("dbo.PersonelProfilleri", new[] { "ID" });
            DropTable("dbo.Depolar");
            DropTable("dbo.Stoklar");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Urunler");
            DropTable("dbo.ZimmetliUrunler");
            DropTable("dbo.Yoneticis");
            DropTable("dbo.KullaniciPersoneller");
            DropTable("dbo.PersonelProfilleri");
            DropTable("dbo.Departmanlar");
        }
    }
}
