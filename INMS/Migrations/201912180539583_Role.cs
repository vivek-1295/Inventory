namespace INMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Role : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleName = c.String(nullable: false, maxLength: 255),
                        UserRoleMap_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserRoleMaps", t => t.UserRoleMap_Id)
                .Index(t => t.roleName, unique: true)
                .Index(t => t.UserRoleMap_Id);
            
            CreateTable(
                "dbo.UserRoleMaps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        roleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userName = c.String(nullable: false, maxLength: 255),
                        password = c.String(nullable: false),
                        UserRoleMap_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.UserRoleMaps", t => t.UserRoleMap_Id)
                .Index(t => t.userName, unique: true)
                .Index(t => t.UserRoleMap_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserRoleMap_Id", "dbo.UserRoleMaps");
            DropForeignKey("dbo.Roles", "UserRoleMap_Id", "dbo.UserRoleMaps");
            DropIndex("dbo.Users", new[] { "UserRoleMap_Id" });
            DropIndex("dbo.Users", new[] { "userName" });
            DropIndex("dbo.Roles", new[] { "UserRoleMap_Id" });
            DropIndex("dbo.Roles", new[] { "roleName" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoleMaps");
            DropTable("dbo.Roles");
        }
    }
}
