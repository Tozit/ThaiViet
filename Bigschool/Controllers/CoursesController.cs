using Bigschool.Models;
using Bigschool.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bigschool.Controllers
{
    public class CoursesController : Controller
    {

        private readonly ApplicationDbContext _dbContext;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(ViewModel);
        }
        /*       [Authorize]
               [HttpPost]
               public ActionResult Create(CourseViewModel ViewModel)
               {
                   var course = new Course
                   {
                       LecturerId = User.Identity.GetUserId();
                   DateTime = viewModel.GetDateTime(),
                   Place = ViewModel.Place};
               _dbContext.Course.Add(Course);
               _dbContext.SaveChanges();
                 return RedirectToAction("Index","Home");      
                   }      
           */
    }
}