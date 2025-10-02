using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_DB.Controllers;

public class HomeEmployeeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}