using System.Data.Entity;
using CP.Data.Models;

namespace CP.Data
{
    public class TestDb : DbContext
    {
        public TestDb()
            : base("name=TestDb")
        {
            Database.SetInitializer(new TestDbInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(u => u.Users)
                .WithRequired(r => r.Role)
                .HasForeignKey(f => f.RoleId);
        }

        /*CreateTable(
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
                .PrimaryKey(t => t.Id);*/
    }
}