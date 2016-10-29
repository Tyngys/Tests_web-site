using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP.Business.Abstract;
using CP.Data;
using CP.Data.Models;
using Microsoft.Practices.Unity;

namespace CP.Business
{
    public class SecondTestService : ISecondTestService
    {
        public SecondTestService(IRepository<User> userRepository)
        {
            this.UserRepository = userRepository;
        }

        [Dependency]
        public IUserService User { get; set; }
        public IRepository<User> UserRepository { get; set; }

        public void GetMark(int mark, string name)
        {
            User user = this.User.GetUser(name);
            

            using (TestDb db = new TestDb())
            {
                db.SecondTest.AddOrUpdate(new SecondTest() {Id = user.Id, Mark = mark });
                db.SaveChanges();
            }
        }

        public void Dispose()
        {
            if (this.UserRepository != null)
            {
                this.UserRepository.Dispose();

            }
            if (this.User != null)
            {
                this.User.Dispose();

            }
        }
    }
}
