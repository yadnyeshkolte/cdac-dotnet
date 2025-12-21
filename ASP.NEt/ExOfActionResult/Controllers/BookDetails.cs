using Microsoft.AspNetCore.Mvc;

namespace ExOfActionResult.Controllers
{
    public class BookDetails : Controller
    {
        [Route("bookdetails")]
        public IActionResult Index(int bid)
        {
            return Content($"<H1>This is your book details with Id: {bid}</H1>", "text/html");
        }



    }
}
