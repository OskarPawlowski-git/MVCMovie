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
        public string Welcome(string name, int ID)
        {
            string command;
            command = name + ID.ToString();
            return (command); 
        }
    }
}