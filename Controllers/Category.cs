using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_DB.Controllers;

public class Category : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}