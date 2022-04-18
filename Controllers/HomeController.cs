using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc.Models;


namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var Course = new Course();
            Course.Id = 1;
            Course.Name = "Asp .Net Mvc Kursu";
            return View(Course);
        }
    }
}
