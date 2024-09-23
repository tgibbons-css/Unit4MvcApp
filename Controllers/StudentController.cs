using Microsoft.AspNetCore.Mvc;
using Unit4MvcApp.Models;

namespace Unit4MvcApp.Controllers;

public class StudentController : Controller
{

    StudentRepository studentRepo = new StudentRepository();
    public StudentController()
    {
        
    }

    public IActionResult Index()
    {
        return View(studentRepo.getAllStudents());
    }

    public IActionResult Details(int id)
    {
        StudentModel student = studentRepo.getStudentById(id);
        if (student == null)
        {
            return NotFound();
        }
        return View("Detail", student);
    }
}
