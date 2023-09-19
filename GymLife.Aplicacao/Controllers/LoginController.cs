using GymLife.Models;
using Microsoft.AspNetCore.Mvc;

namespace GymLife.Controllers
{
    public class LoginController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UsuarioViewModel usuarioViewModel)
        {
            return View();
        }
    }
}
