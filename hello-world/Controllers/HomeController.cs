using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello_world.Controllers
{
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from home controller";
        }

        [Route("about")]
        public string About()
        {
            return "About us";
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}
