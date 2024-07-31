using Microsoft.AspNetCore.Mvc;

namespace SimpleCrudAdoNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
