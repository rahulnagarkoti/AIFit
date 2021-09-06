using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NutritionRecommender.Data;
using NutritionRecommender.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionRecommender.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool Login(string email, string password)
        {
            //validateLogin
            var user = _context.Customer.Where(x => x.Email == email).FirstOrDefault();
            if (user == null) 
            {
                //user not found
                return false;
            }
            if (user.Password == password) 
            {
                //authenticated
                return true;
            }

            //password does not match
            return false;
        }

        [HttpPost]
        public bool Register(Customer customer)
        {
            var userExists = _context.Customer.Where(x => x.Email == customer.Email).FirstOrDefault();
            if (userExists != null) 
            {
                //user already exists
                return false;
            }


            return true;
        }
        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
