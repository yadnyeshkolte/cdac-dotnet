using Microsoft.AspNetCore.Mvc;
using ExOfModels.Models;

namespace ExOfModels.Controllers
{
    public class HomeController : Controller

    ///bookstore/1/false?bookid=20&isloggedin=true&author=harsha
    {
        [Route("bookstore/{bookId?}/{isloggedin?}/{author?}")]
        public IActionResult Index([FromRoute] int? bookId, [FromRoute] bool? isloggedin, Book book) 
        {
            //return View();
            if (bookId.HasValue == false) {
                return BadRequest("Book Id is empty");
            
            }
            if (bookId < 0) { 
                return BadRequest("Book Id cannot be negative");
            }

            if (bookId > 1000) {
                return NotFound("Book Id not found");
            }

            if (isloggedin==false) {
                return Unauthorized("you are unauthorised");
            }


            return Content($"Book object has BookId: {bookId} and Author: {book.author}", "text/plain");
        }
    }
}
