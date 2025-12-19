using Microsoft.AspNetCore.Mvc;

namespace ExOfController.Controller
{
    public class HomeController
    {

        [Route("/")]
        //@GetMapping("/home") in java
        public string iNDEX() {
            return "Hello to the index page";
        }

        [Route("home")]
        public string Home() { 
            return "Hello to the home page";
        }

        [Route("about")]
        public string About() {
            return "Hello to the about page";
        }

        [Route("contact-us")]
        public string COntactUs() { 
            return "Hello to the contact us page";
        }


    }
}
