using System;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Food
    {
        public Food()
        {
        }

        [Key]
        public int FoodId { get; set; }

        public string FoodName { get; set; }

        public float EnergyContent { get; set; }

    }
}
