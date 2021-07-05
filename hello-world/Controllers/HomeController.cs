using hello_world.Models;
using hello_world.Services;
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

        IRepository<Book> bookRepository;

        public HomeController()
        {
            bookRepository = new MockBookRepository();
        }

        public ActionResult Index()
        {
            return View(bookRepository.GetAll());
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
