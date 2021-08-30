using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Meal
    {
        public Meal()
        {
        }

        [Key]
        public int MealId { get; set; }

        public List<Food> FoodList { get; set; }

        [Required]
        // Breakfast, Lunch, Dinner, Extra
        public string MealType { get; set; }
    }
}
