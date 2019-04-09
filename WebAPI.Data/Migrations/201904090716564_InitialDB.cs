namespace WebAPI.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleTitle = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Office = c.String(maxLength: 200),
                        PasswordHash = c.Binary(),
                        PasswordSalet = c.Binary(),
                        Role_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Roles", t => t.Role_RoleID)
                .Index(t => t.Role_RoleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles");
            DropIndex("dbo.Users", new[] { "Role_RoleID" });
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
