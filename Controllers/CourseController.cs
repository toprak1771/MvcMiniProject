using Microsoft.AspNetCore.Mvc;
using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int Hour = DateTime.Now.Hour;
            ViewBag.Greeting = Hour > 12 ? "Good Afternoon" : "Good Morning";
            return View("MyView");
        }

        public ViewResult List()
        {
            var list = Repository.Students.Where(i => i.WillAttend == true);
            return View(list);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid) 
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else 
            {
                return View();
            }
            
        }
    }
}
