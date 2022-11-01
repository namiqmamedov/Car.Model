using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;
using WebApplication3.ViewModels.Home;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Group> _groups;
        public HomeController()
        {
            _groups = new List<Group>
            {
                new Group{Id = 1,Limit = 16, Name = "Mercedes", Model = "E-300" }, 
                new Group{Id = 2,Limit = 12, Name = "Audi", Model1 = "A-7 Sportback"},
                new Group{Id = 3,Limit = 14, Name = "Hyundai", Model2 = "Venue"},
            };
        }
      

        public IActionResult Detail(int? id)
        {
            Group group = _groups.Find(g => g.Id == id);

            return View(group);
        }


        
        public IActionResult Index()
        {

            Student student = new Student
            {
                Name = "T",
                Surname = "T",
                Age = 1
            };

            Blog blog = new Blog
            {
                Content = "T",
                Title = "T"
            };

            HomeVM homeVM = new HomeVM
            {
                Student = student,
                Blog = blog,
                Groups = _groups
            };

            return View(homeVM);
        }

        

    }
}
