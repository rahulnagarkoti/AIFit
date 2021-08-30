using Microsoft.Build.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NutritionRecommender.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName= "varchar(50)")]
        public string  Name { get; set; }
        
        [Required]
        public DateTime DOB { get; set; }
        
        [Required]
        public int Height { get; set; }

        [Required]
        public int Weight { get; set; }

        public string TargetBodyType { get; set; }

        public Workout SuggestWorkout { get; set; }

        public Diet SuggestDiet { get; set; }
    }
}
