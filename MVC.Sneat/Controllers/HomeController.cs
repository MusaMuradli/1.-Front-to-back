using Microsoft.AspNetCore.Mvc;

namespace MVC.Sneat.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
