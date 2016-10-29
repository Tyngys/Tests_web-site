namespace CP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSecondTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameRole = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Password = c.String(),
                        P_D = c.Int(nullable: false),
                        A_S = c.Int(nullable: false),
                        S_L = c.Int(nullable: false),
                        N_O = c.Int(nullable: false),
                        K = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.SecondTests",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Mark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.SecondTests", "Id", "dbo.Users");
            DropIndex("dbo.SecondTests", new[] { "Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropTable("dbo.SecondTests");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
