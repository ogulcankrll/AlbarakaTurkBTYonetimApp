namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migVeriDDuzenleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PersonelProfilleri", "SicilNo", c => c.String(nullable: false));
            AlterColumn("dbo.Yoneticis", "SicilNo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yoneticis", "SicilNo", c => c.Int(nullable: false));
            AlterColumn("dbo.PersonelProfilleri", "SicilNo", c => c.Int(nullable: false));
        }
    }
}
