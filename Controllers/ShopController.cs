using Microsoft.AspNetCore.Mvc;

namespace AdminLTE_DB.Controllers;

public class ShopController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}