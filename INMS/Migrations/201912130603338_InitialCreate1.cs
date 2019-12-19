namespace INMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Purchases", "Products_id", "dbo.Products");
            DropIndex("dbo.Purchases", new[] { "Products_id" });
            RenameColumn(table: "dbo.Purchases", name: "Products_id", newName: "productId");
            AlterColumn("dbo.Purchases", "productId", c => c.Int(nullable: false));
            CreateIndex("dbo.Purchases", "productId");
            AddForeignKey("dbo.Purchases", "productId", "dbo.Products", "id", cascadeDelete: true);
            DropColumn("dbo.Purchases", "productIs");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Purchases", "productIs", c => c.Int(nullable: false));
            DropForeignKey("dbo.Purchases", "productId", "dbo.Products");
            DropIndex("dbo.Purchases", new[] { "productId" });
            AlterColumn("dbo.Purchases", "productId", c => c.Int());
            RenameColumn(table: "dbo.Purchases", name: "productId", newName: "Products_id");
            CreateIndex("dbo.Purchases", "Products_id");
            AddForeignKey("dbo.Purchases", "Products_id", "dbo.Products", "id");
        }
    }
}
