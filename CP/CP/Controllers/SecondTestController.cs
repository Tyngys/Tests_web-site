using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CP.Business;
using CP.Business.Abstract;
using CP.Web.Models;
using Microsoft.Practices.Unity;

namespace CP.Web.Controllers
{
    public class SecondTestController : Controller
    {
        [Dependency]
        public IUserService Users { get; set; }
        [Dependency]
        public ISecondTestService SecondTest { get; set; }

        [HttpGet]
        public ActionResult Test_Second()
        {
            return this.View("Test_Second",new TestSecondModel());
        }

        [HttpPost]
        public ActionResult Test_Second(TestSecondModel model)
        {
            if (this.ModelState.IsValid)
            {
                this.SecondTest.GetMark(model.GetMark(model), this.User.Identity.Name);
                return this.RedirectToRoute(new { controller = "Home", action = "HomePage" });
            }
            this.ModelState.AddModelError(string.Empty, "Some answer enter incorrect");
            return this.View("Test_Second");
        }
    }
}