using FitHolic.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FitHolic.Controllers
{
    [RoutePrefix("api/Users")]
    public class UserController : ApiController
    {
        private UserEngine _engine;
        public UserController()
        {
            _engine = new UserEngine();
        }
        

        [Route("Register")]
        [AcceptVerbs( "Post")]
        [HttpPost]
        public HttpResponseMessage Register(User user)
        {
            _engine.RegisterUser(user);
            var message = Request.CreateResponse(HttpStatusCode.Created);
            return message;
            
        }

        [Route("GetAll")]
        [System.Web.Http.AcceptVerbs("Get", "Post", "Put")]
        [System.Web.Http.HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _engine.GetUsers();
        }

        [Route("FindUser/{UserId}")]
        [System.Web.Http.AcceptVerbs("Get", "Post", "Put")]
        [HttpGet]
        public User GetUser(string UserId)
        {
            var user = _engine.GetUser(UserId);
            return user;
        }

        [Route("Login")]
        [System.Web.Http.AcceptVerbs("Get", "Post", "Put")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage Login(User user)
        { 
            var loggedInSuccessfully = _engine.Login(user);
            if(loggedInSuccessfully) Request.CreateResponse(HttpStatusCode.OK);

            return Request.CreateResponse(HttpStatusCode.NotFound, "Please register first");
        }
    }
}

