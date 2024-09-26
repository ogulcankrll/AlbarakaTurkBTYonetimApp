namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migMapDuzenlemeleri : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Urunler", "SeriNumarasi", c => c.String(nullable: false, maxLength: 80));
            AlterColumn("dbo.Raporlar", "Icerik", c => c.String(nullable: false, maxLength: 550));
            AlterColumn("dbo.Stajyerler", "AdSoyad", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Stajyerler", "TcNo", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Stajyerler", "KullaniciAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Stajyerler", "Sifre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.UrunKonumları", "Aciklama", c => c.String(maxLength: 300));
            AlterColumn("dbo.Yoneticis", "Sifre", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yoneticis", "Sifre", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.UrunKonumları", "Aciklama", c => c.String());
            AlterColumn("dbo.Stajyerler", "Sifre", c => c.String());
            AlterColumn("dbo.Stajyerler", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Stajyerler", "TcNo", c => c.String());
            AlterColumn("dbo.Stajyerler", "AdSoyad", c => c.String());
            AlterColumn("dbo.Raporlar", "Icerik", c => c.String());
            AlterColumn("dbo.Urunler", "SeriNumarasi", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
