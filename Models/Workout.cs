using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NutritionRecommender.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        public int Rating { get; set; }
        public int? CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public IEnumerable<Exercise> ExerciseList { get; set; }
    }
}
