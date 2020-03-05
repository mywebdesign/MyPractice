using FitHolic.Models;
using System.Collections.Generic;

namespace FitHolic.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetUser(string UserId);
        IEnumerable<User> GetAllUsers();
    }
}
