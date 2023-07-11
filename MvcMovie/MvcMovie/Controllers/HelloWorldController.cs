using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /Hello World/ 
        //this is a targetable endpoint in the webapp, which combines the http protocol, network location of the webserver (TCP), and target url
        //this is an HTTP GET method callable by appending /HelloWorld/ onto the end of the base url
        /*
        public string Index()
        {
            return "this is my default action...";
        }
        */
        //
        //GET: /Hello World/Welcome
        /*
        public string Welcome()
        {
            return "this is the Welcome action method...";
        }
        */

        // GET: HelloWorld/Welcome
        // Requires using System.Text.Encodings.Web;
        /*
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        */

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
