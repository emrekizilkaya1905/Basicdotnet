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
    return View("CourseList");
  }
}