using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LDSMovieWebApplication_HiramTodd.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        //public string Index()
        //{
        //    return "This is my deafult action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encoding.Web;
        public IActionResult Welcome(string name, int NumTimes = 1)
        {
            // return "This is the Welcome action method...";
            // return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = NumTimes;

            return View();
        }
    }
}
