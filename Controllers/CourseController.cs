using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;
// Course
public class CourseController:Controller {
  // Course/index, course

    public IActionResult Details(int? id) {
      if(id == null) {
        // return Redirect("/course/list");
        return RedirectToAction("List","Course");
      }
    var course=Repository.GetById(id);
    return View(course);
  }
  public IActionResult List() {
    return View("CourseList",Repository.Courses);
  }
}