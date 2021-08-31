using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutritionRecommender.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string FoodName { get; set; }

        [Required]
        public float EnergyContent { get; set; }
    }
}
