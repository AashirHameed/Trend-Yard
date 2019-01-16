namespace Trend_Yard.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        Categoryyy_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Categoryyy_ID)
                .Index(t => t.Categoryyy_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Categoryyy_ID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Categoryyy_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
