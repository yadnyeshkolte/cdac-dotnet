using Microsoft.AspNetCore.Mvc;

namespace ExOfModelbinding.Controllers
{
    public class HomePageController : Controller
    {
        [Route("home/pages/")]
        public IActionResult Index()
        {
            return Content("<H1> This is Redirected page </H1>","text/html");
        }
    }
}
