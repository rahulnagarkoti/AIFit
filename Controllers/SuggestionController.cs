using AIFit.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NutritionRecommender.Data;
using NutritionRecommender.Models;
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
            try
            {
                var userId = int.Parse(HttpContext.Session.GetString("userId"));
                var customer = _context.Customer.Where(x => x.Id == userId).FirstOrDefault();
                var path = _config.GetConnectionString("APIUrl");
                var obj = new CustomerData { height = height, weight = weight, bodyType = bodyType, gender = (int)customer.Gender };

                //api call
                var content = new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");

                HttpResponseMessage res = await client.PostAsync(path, content);
                if (res.IsSuccessStatusCode)
                {
                    var apiResponse = res.Content.ReadAsStringAsync(); //ReadAsAsync<Workout>
                    var temp = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse>(apiResponse.Result);
                    var workout = _context.Workout.Where(x => x.Id == temp.WorkoutId).FirstOrDefault();
                    var exerciseList = _context.WorkoutExercise.Where(x => x.WorkoutId == workout.Id).Include(x => x.Exercise)
                                        .Select(x => new SuggestionViewModel
                                        {
                                            WorkoutId = x.WorkoutId,
                                            ExerciseName = x.Exercise.ExerciseName,
                                            TotalBurn = x.Exercise.EnergyBurnt,
                                            TotalTime = x.Exercise.Duration
                                        }).ToList();
                    ViewBag.Exercises = exerciseList;
                }
                return PartialView("GetSuggestions");

            }
            catch (Exception e)
            {

                throw;
            }

        }

        //return View
        public void SaveSuggestion(int workoutId)
        {
            try
            {
                var userId = Int32.Parse(HttpContext.Session.GetString("userId"));
                var model = new Recommendations()
                {
                    CustomerId = userId,
                    Date = DateTime.Now,
                    WorkoutId = workoutId

                };
                _context.Recommendations.Add(model);
                _context.SaveChanges();

            }
            catch (Exception e)
            {

                throw;
            }

        }

        public IActionResult GetAlternativeSuggestions(int workoutId)
        {
            try
            {
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
            catch (Exception e)
            {
                //log error
                return PartialView("AlternativeSuggestion");
            }
            //get alternative suggestions




        }



    }
}
