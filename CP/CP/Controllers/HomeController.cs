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
        public ITestOneService TestOne { get; set; }

        

        [Authorize(Roles = "user,admin")]
        public ActionResult HomePage(int? page)
        {
            if (this.User.IsInRole("admin"))
            {
                UsersInfo userInfo = new UsersInfo(this.Users.GetAllUsers());
                this.ViewBag.Averg = userInfo.ArrayAverg;
                this.ViewBag.AvergMiss = userInfo.ArrayArgvMiss;
                this.ViewBag.ErrAvergMath = userInfo.ArrayStErrorAvergMath;
                int pageSize = 10;
                int pageNumber = (page ?? 1);
                return this.View("HomePage", userInfo.InfoList.ToPagedList(pageNumber, pageSize));
            }
            return this.View("HomePage");
        }
        [HttpGet]
        public ActionResult Test_One()
        {
            return this.View("Test_One",new TestOneModel());
        }

        [HttpPost]
        public ActionResult Test_One(TestOneModel model)
        {
            this.TestOne.GetMarks(model.GetMarksFromAnswer(model),this.User.Identity.Name);
            return this.View("HomePage");
        }
    }
}