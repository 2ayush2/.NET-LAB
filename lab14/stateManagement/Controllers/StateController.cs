using Microsoft.AspNetCore.Mvc;

namespace State.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult SetUserData(string username, string message)
        {
            HttpContext.Session.SetString("Username", username);
            TempData["Message"] = message;
            return RedirectToAction("Display");
        }

        public IActionResult Display()
        {
            ViewBag.Username = HttpContext.Session.GetString("Username");
            ViewBag.Message = TempData["Message"];
            return View();
        }
    }
}
