using CodingChallenge.DataModel;
using System.Web.Mvc;

namespace CodingChallenge.Web.Controllers
{
    public class UserProjectController : Controller
    {
        private readonly IUserProjectRepository userProjectRepository;
        public UserProjectController(IUserProjectRepository userProjectRepository)
        {
            this.userProjectRepository = userProjectRepository;
        }

        // GET api/user/
        public ActionResult Index()
        {
            return View();
        }

        // GET api/user/id
        public ActionResult Get(int id)
        {
            var userProjects = userProjectRepository.GetUserProjectsByUserId(id);
            return View(userProjects);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                userProjectRepository.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
