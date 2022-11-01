using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels.Home
{
    public class HomeVM
    {
        public Student Student { get; set; }
        public Blog Blog { get; set; }

        public List<Group> Groups { get; set; }
    }
}
