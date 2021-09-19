using NutritionRecommender.Data;
using NutritionRecommender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIFit.Data
{
    public class SeedData
    {
        private readonly ApplicationDbContext _context;
        public SeedData(ApplicationDbContext context) 
        {
            _context = context;
        }
        public void SeedRecommendations() 
        {
            var workouts = _context.Workout.ToList();
            var model = new List<Recommendations>() 
            {
                new Recommendations{CustomerId = 1, Date= DateTime.Now, WorkoutId = 1 }
            };
            foreach(var item in workouts) 
            {
                var temp = new Recommendations { CustomerId = 1, Date = DateTime.Now, WorkoutId = item.Id };
                model.Add(temp);
            }

            _context.AddRange(model);
            _context.SaveChanges();

        }
    }
        
}
