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
        public DbSet<SecondTest> SecondTest { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>()
                .HasMany(u => u.Users)
                .WithRequired(r => r.Role)
                .HasForeignKey(f => f.RoleId);

            modelBuilder.Entity<SecondTest>()
                .HasRequired(t => t.User)
                .WithOptional(t => t.SecondTest);
        }
    }
}