using Microsoft.AspNetCore.Mvc;
using ExOfModels.Models;
namespace ExOfModels.Controllers
{
    public class StoreController: Controller
    {

        //https://localhost:7224/store/books/10?id=10 
        //You id is 10

        //https://localhost:7224/store/books/10?id=39
        //You id is 10
        [Route("store/books/{bid}")]
        public IActionResult Books() {
            int id = Convert.ToInt32(Request.RouteValues["bid"]);
            return Content($"<H1>You id is {id}</H1>", "text/html");
        }
    }
}
