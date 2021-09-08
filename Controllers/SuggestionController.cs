using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NutritionRecommender.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AIFit.Controllers
{

    public class SuggestionController : ControllerBase
    {
        private IConfiguration _config;
        private readonly ApplicationDbContext _context;
        static HttpClient client = new HttpClient();
        public SuggestionController(IConfiguration config, ApplicationDbContext context) 
        {
            _config = config;
            _context = context;

        }

        public string GetSuggestions(decimal height, decimal weight, string bodyType) 
        {
            var userId = int.Parse(HttpContext.Session.GetString("userId"));
            var customer = _context.Customer.Where(x => x.Id == userId).FirstOrDefault();
            var path = _config.GetConnectionString("APIUrl");
            var obj = new { height = height, weight = weight, bodyType = bodyType, gender = customer.Gender };

            /*
            //api call
            HttpResponseMessage res = await client.GetAsync(path);
            if (res.IsSuccessStatusCode) 
            {
                var data = res.Content.ReadAsStringAsync(); //ReadAsAsync<Workout>
                //do something with the data
            }
            */


            return " ";

        }

        public async Task<string> ApiCall(object obj)
        {
            var path = _config.GetConnectionString("APIUrl");

            /*
            api call
            HttpResponseMessage res = await client.GetAsync(path,obj);
            res.EnsureSuccessStatusCode();

            if (res.IsSuccessStatusCode) 
            {
                var data = res.Content.ReadAsStringAsync(); //ReadAsAsync<Workout>
                do something with the data
            }
            */
            return "";
        }
    }
}
