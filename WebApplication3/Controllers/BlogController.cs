using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            Blog blog = new Blog
            {
                Content = "Hey",
                Title = "Zip"
            };

            return View(blog);
        }
    }
}
