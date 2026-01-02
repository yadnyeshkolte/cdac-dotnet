using CSRFDefence.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CSRFDefence.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowDetails() {
            return View();
        }

        [HttpPost]  
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection fc) {
            ViewBag.username = fc["uname"];
            ViewBag.hashpassword = fc["password"];
            return View("ViewDetails");
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
