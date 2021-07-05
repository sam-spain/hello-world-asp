using hello_world.Models;
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
        public ActionResult Index()
        {
            Book book = new Book()
            {
                Title = "Learning ASP",
                Description = "Sam's attempt to learn this stuff",
                Author = "Andrew Anders",
                PublishDate = "July, 2021",
                Price = 35,
                Image = ""
            };
            return View(book);
        }

        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}
