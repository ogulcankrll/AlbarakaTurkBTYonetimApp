namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigDepartmanSatırEkle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departmanlar", "DepartmanKat", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Departmanlar", "DepartmanKat");
        }
    }
}
