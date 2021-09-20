using AIFit.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NutritionRecommender.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AIFit.Controllers
{

    public class SuggestionController : Controller
    {
        private IConfiguration _config;
        private readonly ApplicationDbContext _context;
        static HttpClient client = new HttpClient();
        public SuggestionController(IConfiguration config, ApplicationDbContext context) 
        {
            _config = config;
            _context = context;

        }

        public async Task<IActionResult> GetSuggestions(decimal height, decimal weight, int bodyType)
        {
            var userId = int.Parse(HttpContext.Session.GetString("userId"));
            var customer = _context.Customer.Where(x => x.Id == userId).FirstOrDefault();
            var path = _config.GetConnectionString("APIUrl");
            var obj = new CustomerData { height = height, weight = weight, bodyType = bodyType, gender = (int)customer.Gender};
            //var content = new MultipartFormDataContent();
            //content.Add(new StringContent(weight.ToString()), "weight");
            //content.Add(new StringContent(bodyType.ToString()), "height");
            //content.Add(new StringContent(customer.Gender.ToString()), "gender");
            //content.Add(new StringContent(weight.ToString()), "weight");

            //api call
            var content = new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");

            HttpResponseMessage res = await client.PostAsync(path, content);
            if (res.IsSuccessStatusCode)
            {
                var apiResponse = res.Content.ReadAsStringAsync(); //ReadAsAsync<Workout>
                var temp = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse>(apiResponse.Result);
                var workout = _context.Workout.Where(x => x.Id == temp.WorkoutId).FirstOrDefault();

                //do something with the data
            }

            var exercises = new List<SuggestionViewModel>()
            {
                new SuggestionViewModel{ ExerciseName = "Jogging", TotalBurn=200, TotalTime=15},
                new SuggestionViewModel{ ExerciseName = "Swimming", TotalBurn=400, TotalTime=15},
                new SuggestionViewModel{ ExerciseName = "Jumping", TotalBurn=300, TotalTime=15},
                new SuggestionViewModel{ ExerciseName = "Cycling", TotalBurn=600, TotalTime=15}
            };
            ViewBag.Exercises = exercises;
            return PartialView("GetSuggestions");
             
        }


        public IActionResult GetAlternativeSuggestions()
        {
            //get alternative suggestions
           

            var exercises = new List<SuggestionViewModel>()
            {
                new SuggestionViewModel{ ExerciseName = "Squats", TotalBurn=100, TotalTime=10 },
                new SuggestionViewModel{ ExerciseName = "Pushups", TotalBurn=375, TotalTime=1 },
                new SuggestionViewModel{ ExerciseName = "Jumping", TotalBurn=300, TotalTime=15 },
                new SuggestionViewModel{ ExerciseName = "Sprinting", TotalBurn=600, TotalTime=2 }
            };
            ViewBag.Exercises = exercises;
            return PartialView("AlternativeSuggestion");

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

    public class CustomerData 
    {
        public decimal weight { get; set; }
        public decimal height { get; set; }
        public int bodyType { get; set; }
        public int gender { get; set; }
    }

    public class ApiResponse 
    {
        public int WorkoutId { get; set; }
        public int StatusCode { get; set; }
    }
  
}
