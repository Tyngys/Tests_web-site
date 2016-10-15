using System.Web.Mvc;
using CP.Business;
using CP.Business.Abstract;
using CP.Web.Models;
using Microsoft.Practices.Unity;
using PagedList;

namespace CP.Web.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public IUserService Users { get; set; }
        [Dependency]
        public ITestService Test { get; set; }

        [Authorize(Roles = "user,admin")]
        public ActionResult HomePage(int? page)
        {
            if (this.User.IsInRole("admin"))
            {
                int pageSize = 3;
                int pageNumber = (page ?? 1);
                return this.View("HomePage", this.Users.GetAllUsers().ToPagedList(pageNumber, pageSize));
            }
            return this.View("HomePage");
        }
        [HttpGet]
        public ActionResult Test_One()
        {
            return this.View("Test_One",new AllTestModel());
        }

        [HttpPost]
        public ActionResult Test_One(AllTestModel model)
        {
            this.Test.GetMarks(model.GetMarksFromAnswer(model),this.User.Identity.Name);
            return this.View("HomePage");
        }
    }
}