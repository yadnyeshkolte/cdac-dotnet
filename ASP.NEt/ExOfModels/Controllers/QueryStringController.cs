using Microsoft.AspNetCore.Mvc;
using ExOfModels.Models;
namespace ExOfModels.Controllers
{
    public class QueryStringController : Controller
    {
        [Route("querybooks/")]
        public IActionResult Index([FromQuery] int? bookId, [FromQuery] string? author, Book book)
        {
            if (bookId.HasValue == false) { 
                return BadRequest("Book Id is empty");
            }

            if (bookId < 0) {
                return BadRequest("Book Id cannot be negative");
            }


            if (string.IsNullOrWhiteSpace(author)) {
                return NotFound("Author is not added: or entered white space");
            }


            if (bookId.HasValue == true & author is null or "") {
                return Content("Book id present but author is not entered","text/plain");
            
            }
            return Content($"Query string Working Book details:{bookId} Author {author}", "text/plain");
        }
    }
}
