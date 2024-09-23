using Microsoft.AspNetCore.Mvc;

namespace Unit4MvcApp.Controllers;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        //return Content("Hello World");
        return View();
    }

    public IActionResult MN()
    {
        return View("MN");
    }

    public IActionResult Minnesota()
    {
        return View("MN");
    }


    public IActionResult WI()
    {
        return View("WI");
    }
}


