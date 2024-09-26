namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migHataKontrol : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Urunler", "UrunAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunler", "UrunAdi", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
