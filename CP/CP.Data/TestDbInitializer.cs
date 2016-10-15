using System.Data.Entity;
using CP.Data.Models;

namespace CP.Data
{
    internal class TestDbInitializer : CreateDatabaseIfNotExists<TestDb>
    {
        protected override void Seed(TestDb context)
        {
            base.Seed(context);

            context.Roles.Add(new Role {NameRole = "admin"});
            context.Roles.Add(new Role {NameRole = "user"});
            context.SaveChanges();
        }
    }
}
