namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migRaporDuzenleme : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Raporlar", name: "OnaylayanYoneticiID", newName: "Yonetici_ID");
            RenameIndex(table: "dbo.Raporlar", name: "IX_OnaylayanYoneticiID", newName: "IX_Yonetici_ID");
            DropColumn("dbo.Raporlar", "OnaylandiMi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Raporlar", "OnaylandiMi", c => c.Boolean(nullable: false));
            RenameIndex(table: "dbo.Raporlar", name: "IX_Yonetici_ID", newName: "IX_OnaylayanYoneticiID");
            RenameColumn(table: "dbo.Raporlar", name: "Yonetici_ID", newName: "OnaylayanYoneticiID");
        }
    }
}
