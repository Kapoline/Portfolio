using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers;

public class UserController : Controller
{
    public IActionResult UserProfile()
    {
        return View();
    }
}