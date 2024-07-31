using Microsoft.AspNetCore.Mvc;
using lab12.Services; // Adjust namespace to match your folder structure

namespace lab12.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMessageService _services;

        public HomeController(IMessageService services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            string message = _services.GetMessage();
            return View(model: message);
        }
    }
}
