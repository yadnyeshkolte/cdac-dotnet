using Microsoft.AspNetCore.Mvc;

namespace ExOfModelbinding.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Controller Connected", "text/plain");
        }

        [Route("")]
        public IActionResult Store()
        {
            return Content("Test Action Invoked", "text/plain");
        }
    }
}
