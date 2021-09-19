using NutritionRecommender.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AIFit.Models
{
    public class WorkoutExercise
    {
        [Key]
        public int Id { get; set; }
        public int WorkoutId { get; set; }
        public int ExerciseId { get; set; }

        [ForeignKey("WorkoutId")]
        public Workout Workout { get; set; }

        [ForeignKey("ExerciseId")]
        public Exercise Exercise { get; set; }

    }
}
