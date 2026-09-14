using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get: /HelloWorld/Index
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/ 
        //public string Welcome(String name, int numTimes = 1)
        public string Welcome(String name, int ID = 1)
        {
            //return "This is the Welcome action method...";
            // safely converts strings into HTML-encoded text to prevent cross-site scripting (XSS) attacks in .NET applications
            //return HtmlEncoder.Default.Encode($"Hello {name}, NumTime is: {numTimes} ");
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID} ");
        }

    }
}
