using CodingChallenge.DataModel;
using CodingChallenge.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace CodingChallenge.Web.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        // GET api/user
        public IEnumerable<User> Get()
        {
            return userRepository.GetAllUsers();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                userRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
