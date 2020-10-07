using LogIn.Model;
using LogIn.Web.ServiceCaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LogIn.Web.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogInPage()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> LogInPage(User user)
        {
            var res = await Service.validate(user.UserName, user.PassWord);
            if (res)
                return RedirectToAction("Index");
            else
            return View();
        }
    }
}