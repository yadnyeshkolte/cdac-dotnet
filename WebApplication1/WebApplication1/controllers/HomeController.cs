using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("home")]
        public string Method => "Index";
        //it wiil be on index

        public string Method1()
        {
            return "Hello World";
        }
        public FileContentResult FileContent()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/sample.pdf");
            string fileName = "sample.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, fileName);

        }

        public VirtualFileResult VirtualFile()
        {
            string filePath = "~/sample.pdf";
            string contentType = System.Net.Mime.MediaTypeNames.Application.Pdf;
            return File(filePath, contentType);
        }
        

        public PhysicalFileResult PhysicalFile()
        {
            string filePath = "wwwroot/sample.pdf";
            string contentType = System.Net.Mime.MediaTypeNames.Application.Pdf;
            return File(filePath, contentType);
        }


    }
}
