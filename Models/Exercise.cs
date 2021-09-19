using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutritionRecommender.Models
{
    public class Exercise
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ExerciseName { get; set; }

        [Required]
        public float EnergyBurnt { get; set; }

        [Required]
        public float Duration { get; set; }

    }
}
