using System.Collections.Generic;
using CP.Data.Models;

namespace CP.Business
{
    public interface IUserService : IServiceBase
    {
        bool ValidateUser(string userName, string password);
        User GetUser(string userName);
        List<User> GetAllUsers();
        bool AddUser(User user);
    }
}