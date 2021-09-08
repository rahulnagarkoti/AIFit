using AIFit.Controllers;
using AIFit.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NutritionRecommender.Data;
using NutritionRecommender.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace NutritionRecommender.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private  HelperMethods _helper;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            _helper = new HelperMethods();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login() 
        {
            //check if user is logged in -> if yes, direct to Home Page
            var userId = GetCurrentUserId();
            if (userId != 0)
            {
                //user is logged in
                return HomePage();
            }

            return PartialView();
        }

        [HttpPost]
        public Result Login(string email, string password)
        {
            var result = new Result();
            try
            {
                //validateLogin
                var user = _context.Customer.Where(x => x.Email == email).FirstOrDefault();
                if (user == null)
                {
                    //user not found
                    result.IsError = true;
                    result.ErrorMessage = "User not found!";
                    return result;
                }

                if (_helper.ValidatePassword(user.Password, password))
                {
                    //authenticated
                    //store user Id in session
                    HttpContext.Session.SetString("userId", user.Id.ToString()); 
                    result.IsError = false;
                    return result;
                }

                //password does not match
                result.IsError = true;
                result.ErrorMessage = "Incorrect Password!";
                return result;

            }
            catch (Exception e)
            {

                throw;
            }


        }

        [HttpPost]
        public Result Register(Customer customer)
        {
            var result = new Result();
            try
            {
                var userExists = _context.Customer.Where(x => x.Email == customer.Email).FirstOrDefault();
                if (userExists != null)
                {
                    //user already exists
                    result.IsError = true;
                    result.ErrorMessage = "The user does not exist!";
                    return result;
                }
                //validate email
                if (!_helper.ValidateEmail(customer.Email)) 
                {
                    result.IsError = true;
                    result.ErrorMessage = "Email is invalid!";
                    return result;
                }

                //validate date
                if (customer.DOB >= DateTime.Now.Date) 
                {
                    result.IsError = true;
                    result.ErrorMessage = "D.O.B is invalid!";
                }

                //hash password
                var hashPwd = Crypto.HashPassword(customer.Password);
                customer.Password = hashPwd;
                _context.Customer.Add(customer);
                _context.SaveChanges();
                HttpContext.Session.SetString("userId", customer.Id.ToString());
                result.IsError = false;
                return result;
            }
            catch (Exception e)
            {
                //log the error in DB or text file
                result.IsError = false;
                result.ErrorMessage = "Internal Server Error!";
                return result;
            }
           
        }
        public IActionResult HomePage()
        {
            var userId = GetCurrentUserId();

            if (userId == 0) 
            {
                return PartialView("Login");
            }
            return PartialView();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Logout() 
        {
            HttpContext.Session.SetString("userId", null);
            return PartialView("Login");
        }

        public int GetCurrentUserId() 
        {
            var userId = HttpContext.Session.GetString("userId");
            if (userId == null)
                return 0;
            else
                return Int32.Parse(userId);

        }    

    }
}
