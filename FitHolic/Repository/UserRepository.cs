using FitHolic.Models;
using FitHolic.Models.Data;
using System.Collections.Generic;
using System.Linq;


namespace FitHolic.Repository
{
    public class UserRepository : IUserRepository
    {
        public FitHolicDbContext _context;

        public UserRepository()
        {
            _context = new FitHolicDbContext();
        }
        public void Add(User user)
        {                 
            _context.Users.Add(user);
            _context.SaveChanges();  
        }

        public IEnumerable<User> GetAllUsers()
        {
            List<User> result = _context.Users.ToList(); //new List<User>();
            return result;
        }

        public User GetUser(string UserId)
        {
            var user = _context.Users.Where(x => x.Email == UserId).FirstOrDefault();
            return user;
        }
    }
}