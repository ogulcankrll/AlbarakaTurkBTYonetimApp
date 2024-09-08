namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KullaniciPersoneller", "SicilNo", c => c.String());
            AddColumn("dbo.Yoneticis", "SicilNo", c => c.Int(nullable: false));
            AlterColumn("dbo.PersonelProfilleri", "SicilNo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PersonelProfilleri", "SicilNo", c => c.String(nullable: false, maxLength: 25));
            DropColumn("dbo.Yoneticis", "SicilNo");
            DropColumn("dbo.KullaniciPersoneller", "SicilNo");
        }
    }
}
