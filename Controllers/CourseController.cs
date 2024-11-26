using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;
// Course
public class CourseController:Controller {
  // Course/index, course
  public IActionResult Index() {
    var course=new Course();
    course.Id=1;
    course.Title="ASP.NET COURSE";
    course.Description = "Nice course";
    return View(course);
  }
  public IActionResult List() {
    var courses=new List<Course>() {
      new Course {Id = 1, Title ="ASP.NET COURSE",Description="Nice Course" },
      new Course {Id = 2, Title ="PHP COURSE",Description="Nice Course" },
      new Course {Id = 3, Title ="JAVASCRIPT COURSE",Description="Nice Course" },
        new Course {Id = 4, Title ="PHYTON COURSE",Description="Nice Course" },
    };
    return View("CourseList",courses);
  }
}