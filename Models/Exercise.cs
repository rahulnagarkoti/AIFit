using System;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Exercise
    {
        public Exercise()
        {
        }

        [Key]
        public int ExerciseId { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        [Required]
        public float EnergyBurnt { get; set; }
    }
}
