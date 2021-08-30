using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NutritionRecommender.Models
{
    public class Workout
    {
        public Workout()
        {
        }

        [Key]
        public int WorkoutId { get; set; }

        public List<Exercise> ExerciseList { get; set; }

        public int Rating { get; set; }
    }
}
