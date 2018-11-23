using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagmentFin.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventManagment.Controllers
{
    [AllowAnonymous]
    
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext) {this.dbContext = dbContext;}

        [AllowAnonymous]
        [Authorize(Roles="Administrator")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Events()
        {
            var events = dbContext.Events.ToList();
            return View(events);
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Speaker()
        {
            return View();
        }
    }
}