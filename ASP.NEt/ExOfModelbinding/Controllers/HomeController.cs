using ExOfModelbinding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExOfModelbinding.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return Content("Controller Connected", "text/plain");
        }

        [Route("bookstore/")]
        public IActionResult Store()
        {
            return Content("Books will be available", "text/plain");
        }


        //https://localhost:7231/bookstore/1/true?book.author=ui&book.title=yui
        // Book is 1 ui yui
        [Route("bookstore/{bookId?}/{isloggedin?}")]
        public IActionResult Books([FromRoute] int? bookId, [FromRoute] bool? isloggedin, Book book)
        {
            if (bookId.HasValue == false) {
                return NotFound("Not found");
            }

            if (book.author is null or " " == false && string.IsNullOrWhiteSpace(book.title) == false) {
                book.bookId = Convert.ToInt32(bookId);
                return Content(book.ToString(), "text/plain");
            }

            if (bookId == 2)
            {
                return RedirectToAction("Index", "HomePage");
            }
            //https://localhost:7231/bookstore/2/true
            //This is Redirected page

            if (bookId == 3)
            {
                return RedirectToAction("AboutIndex", "AboutPage");
            }
            //https://localhost:7231/bookstore/3/true
            //This is Redirected About page
            return Content("List of Books", "text/plain");
        }
    }
}
