namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migZimmetIslem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ZimmetliUrunler", "urunDurumu", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ZimmetliUrunler", "urunDurumu");
        }
    }
}
