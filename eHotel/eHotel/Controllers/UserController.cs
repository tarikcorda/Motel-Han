using Microsoft.AspNetCore.Mvc;

namespace eHotel.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
