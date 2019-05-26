using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserApp.DBContext;

namespace UserApp.Controllers
{
    public class HomeController : Controller
    {
        private UserAppContext db = new UserAppContext();

        public ActionResult Index()
        {
            return View(db.User.ToList());
        }
    }
}
