using Microsoft.AspNetCore.Mvc;

namespace ExOfRazorView.Controllers
{
    public class HomeController : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
