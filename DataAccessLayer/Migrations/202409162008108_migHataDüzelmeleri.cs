namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migHataDüzelmeleri : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UrunKonumları", "PersonelID", "dbo.PersonelProfilleri");
            DropIndex("dbo.UrunKonumları", new[] { "PersonelID" });
            AlterColumn("dbo.UrunKonumları", "PersonelID", c => c.Int());
            CreateIndex("dbo.UrunKonumları", "PersonelID");
            AddForeignKey("dbo.UrunKonumları", "PersonelID", "dbo.PersonelProfilleri", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UrunKonumları", "PersonelID", "dbo.PersonelProfilleri");
            DropIndex("dbo.UrunKonumları", new[] { "PersonelID" });
            AlterColumn("dbo.UrunKonumları", "PersonelID", c => c.Int(nullable: false));
            CreateIndex("dbo.UrunKonumları", "PersonelID");
            AddForeignKey("dbo.UrunKonumları", "PersonelID", "dbo.PersonelProfilleri", "ID", cascadeDelete: true);
        }
    }
}
