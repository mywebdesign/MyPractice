using FitHolic.Models;
using FitHolic.Repository;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace FitHolic
{
    public class UserEngine
    {
        public IUserRepository _repository;

        public UserEngine()
        {
            _repository = new UserRepository();
        }
        public bool RegisterUser(User user)
        {
            //var userLocal = _repository.GetUser(user.Email);

            //if (userLocal != null) return false;

            //_repository.Add(user);
            //return true;
        }
        public bool Login(User user)
        {
            //var localUser = _repository.GetUser(user.Email);

            //if (localUser != null && localUser.Password == user.Password) return true;

            //return false;
        }

        public User GetUser(string UserId)
        {
            //var user = _repository.GetUser(UserId);
            //if(user==null)
            //{
            //    throw new HttpResponseException(HttpStatusCode.NotFound);
            //}
            //return user;
        }
        public IEnumerable<User> GetUsers()
        {
            return _repository.GetAllUsers();

        }        
    }
}
