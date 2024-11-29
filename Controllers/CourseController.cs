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
    course.Image = "1.jpeg";
    return View(course);
  }
  public IActionResult List() {
    var courses=new List<Course>() {
      new Course {Id = 1, Title ="ASP.NET COURSE",Description="Nice Course", Image="1.jpeg" },
      new Course {Id = 2, Title ="PHP COURSE",Description="Nice Course", Image="2.jpeg" },
      new Course {Id = 3, Title ="DJANGO COURSE",Description="Nice Course",Image="3.jpeg" },
    };
    return View("CourseList",courses);
  }
}