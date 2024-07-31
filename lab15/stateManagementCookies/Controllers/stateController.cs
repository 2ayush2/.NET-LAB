using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StateManagementCookies.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetUserData(string username, string message)
        {
            // Store user data in cookies
            Response.Cookies.Append("Username", username, new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMinutes(30) });
            Response.Cookies.Append("Message", message, new CookieOptions { Expires = DateTimeOffset.UtcNow.AddMinutes(30) });

            return RedirectToAction("Display");
        }

        public IActionResult Display()
        {
            // Retrieve user data from cookies
            string username = Request.Cookies["Username"];
            string message = Request.Cookies["Message"];

            ViewBag.Username = username;
            ViewBag.Message = message;

            return View();
        }
    }
}
