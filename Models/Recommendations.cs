using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionRecommender.Models
{
    public class Recommendations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int MealId { get; set; }
        [Required]
        public int WorkoutId { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("MealId")]
        public Meal Meal { get; set; }

        [ForeignKey("WorkoutId")]
        public Workout Workout { get; set; }
    }
}
