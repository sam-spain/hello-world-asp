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
            List<Book> books = new List<Book>();
            Book learningAsp = new Book()
            {
                Title = "Learning ASP",
                Description = "Sam's attempt to learn this stuff",
                Author = "Andrew Anders",
                PublishDate = "July, 2021",
                Price = 35,
                Image = ""
            };
            Book learningSpring = new Book()
            {
                Title = "Learning Java Spring",
                Description = "Sam's attempt build better knowledge of this stuff",
                Author = "Berty Boblin",
                PublishDate = "November, 2018",
                Price = 5,
                Image = ""
            };
            books.Add(learningAsp);
            books.Add(learningSpring);
            return View(books);
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
