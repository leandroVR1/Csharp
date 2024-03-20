using Microsoft.AspNetCore.Mvc;
namespace Mvc.Controllers //apuntar a laa carpeta controller

{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Login()
        {
            return View();
        }
    }
}