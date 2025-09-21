using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_DB.Controllers;

public class Product : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}