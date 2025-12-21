using Microsoft.AspNetCore.Mvc;

namespace ExOfActionResult.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore")]

        
        public IActionResult Index()
        {

            if (Request.Query.ContainsKey("bookId") == false) { //it return boolean not the value itself
                Response.StatusCode = 400;
                return Content("Bad Request: Missing bookId parameter", "text/plain");
            }

            if (String.IsNullOrEmpty(Convert.ToString(Request.Query["bookId"]))) {
                return Content("Books Id can't be null and empty", "text/plain");
            }

            //bookId should be between 1 and 1000 
            int bookId = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookId"]);
            // as the integer is the 32 bit integer so thats why we need to use ToInt32

            if (bookId<0) {
                return BadRequest("Value cannot be negative and so");
            }
            if (bookId>1000) {
                return BadRequest("Book is not present it is much bigger");
            }
            if (bookId>0 && bookId<1000) {
                return RedirectToAction("Index", "BookDetails", new { bid = bookId});


                //https://localhost:7140/bookstore?bookId=34
                
                // --> it will redirect to the below link

                //https://localhost:7140/bookdetails?bid=34
                //This is your book details with Id: 34
            }

            return Content("It the Index page", "text/plain");
        }
    }
}
