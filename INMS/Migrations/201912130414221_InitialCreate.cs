namespace INMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        firstName = c.String(),
                        LastName = c.String(),
                        User = c.String(),
                        productId = c.Int(nullable: false),
                        numberShipped = c.String(),
                        orderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        productName = c.String(nullable: false, maxLength: 30),
                        partNumber = c.String(nullable: false, maxLength: 30),
                        productLabel = c.String(nullable: false, maxLength: 30),
                        startingInventory = c.Int(nullable: false),
                        InventoryReceived = c.Int(nullable: false),
                        InventoryShipped = c.Int(nullable: false),
                        InventoryOnHand = c.Int(nullable: false),
                        MinimumRequired = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        supplierId = c.Int(nullable: false),
                        productIs = c.Int(nullable: false),
                        NumberReceived = c.String(),
                        purchaseDate = c.DateTime(nullable: false),
                        Products_id = c.Int(),
                        Suppliers_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.Products_id)
                .ForeignKey("dbo.Suppliers", t => t.Suppliers_id)
                .Index(t => t.Products_id)
                .Index(t => t.Suppliers_id);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        supplier = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "productId", "dbo.Products");
            DropForeignKey("dbo.Purchases", "Suppliers_id", "dbo.Suppliers");
            DropForeignKey("dbo.Purchases", "Products_id", "dbo.Products");
            DropIndex("dbo.Purchases", new[] { "Suppliers_id" });
            DropIndex("dbo.Purchases", new[] { "Products_id" });
            DropIndex("dbo.Orders", new[] { "productId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Purchases");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
        }
    }
}
