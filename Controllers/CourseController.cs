using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;
// Course
public class CourseController:Controller {
  // Course/index, course
  public IActionResult Index() {
    return View();
  }
  public IActionResult List() {
    return View("CourseList");
  }
}