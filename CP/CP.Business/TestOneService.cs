using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Microsoft.Practices.Unity;
using CP.Business.Abstract;
using CP.Data;
using CP.Data.Models;
namespace CP.Business
{
    public class TestOneService : ITestOneService
    {
        public TestOneService(IRepository<User> userRepository)
        {
            this.UserRepository = userRepository;
        }

        [Dependency]
        public IUserService User { get; set; }
        public IRepository<User> UserRepository { get; set; }

        public void GetMarks(int[] marks, string name)
        {
           var user = this.User.GetUser(name);
            user.P_D = marks[0];
            user.A_S = marks[1];
            user.S_L = marks[2];
            user.N_O = marks[3];
            user.K = marks[4];
            using (TestDb db = new TestDb())
            {
                db.Users.AddOrUpdate(user);
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
