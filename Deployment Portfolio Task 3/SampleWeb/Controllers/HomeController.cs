using Microsoft.AspNetCore.Mvc;
using SampleWeb.Models;
using System.Diagnostics;

namespace SampleWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Show the message
        /// </summary>
        /// <returns>message</returns>
        [HttpPost]
        public ActionResult ShowMessage()
        {
            ViewBag.Message = "Hello World";
            return View("Index");
        }


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
