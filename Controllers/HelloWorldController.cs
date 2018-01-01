using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace McvcMovie.Controlles
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes =1)
        {
            ViewData["Massage"] = "Hello "+ name;
            ViewData["Numtimes"] = numTimes;

            return View();
        }
    }
}