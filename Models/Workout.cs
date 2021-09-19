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
        public int? Rating { get; set; }
    }
}
