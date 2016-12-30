using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Management.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LoginSubmit(string user, string password)
        {
            bool result = false;
            if (user.Equals(password))
            {
                result = true;
            }

            return Json(result,JsonRequestBehavior.AllowGet);
        }
    }
}