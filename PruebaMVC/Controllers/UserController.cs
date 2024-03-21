using Microsoft.AspNetCore.Mvc;
namespace Mvc.Controllers //apuntar a laa carpeta controller

{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult GstUser()
        {
            return View();
        }
        public IActionResult GstProductos()
        {
            return View();
        }

        
    }
}

/*
clases

-DeshboarController
+index()

-AuthController
+Login()
+Register()

-UsuariosController
+Index()
+Create()
+Show()
+Delete()
+Update()
+Edit()

*/