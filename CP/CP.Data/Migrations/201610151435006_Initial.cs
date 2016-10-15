namespace CP.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    UserName = c.String(),
                    Gender = c.String(),
                    Age = c.Int(nullable: true),
                    Password = c.String(),
                    P_D = c.Int(nullable: true),
                    A_S = c.Int(nullable: true),
                    S_L = c.Int(nullable: true),
                    N_O = c.Int(nullable: true),
                    K = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id);
            CreateTable(
                "dbo.Roles",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    NameRole = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {

        }
    }
}
