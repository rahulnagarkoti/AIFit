using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public int Rating { get; set; }
        public IEnumerable<Exercise> ExerciseList { get; set; }
    }
}
