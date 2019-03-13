using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace LDSMovieWebApplication_HiramTodd.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my deafult action...";
        }

        //
        //GET: /HelloWorld/Welcome/

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
