using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleAuthenticationProject.Controllers
{
    public class StudentController : Controller
    {
        [Authorize]
        // GET: Student
        public ActionResult Index()
        {
            if (User.IsInRole("admin"))
            {
                return View("Admin");
            }
            else
            {
                return View("Student");
            }
        }
    }
}