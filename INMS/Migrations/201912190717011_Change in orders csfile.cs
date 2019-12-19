namespace INMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changeinorderscsfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "shippmentNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "status");
            DropColumn("dbo.Orders", "shippmentNumber");
        }
    }
}
