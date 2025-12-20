using Microsoft.AspNetCore.Mvc;

namespace ExOfModelbinding.Controllers
{
    public class AboutPageController : Controller
    {
        [Route("about/pages/")]
        public IActionResult AboutIndex()
        {
            return Content("<H1> This is Redirected About page </H1>", "text/html");
        }
    }
}
