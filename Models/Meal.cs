using NutritionRecommender.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public MealType MealType { get; set; }
        public IEnumerable<Food> FoodList { get; set; }
    }
}
