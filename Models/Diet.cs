using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Diet
    {
        public Diet()
        {
        }

        [Key]
        public int DietId { get; set; }

        public List<Meal> MealList { get; set; }

        public int Ratings { get; set; }
    }
}
