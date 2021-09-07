using AIFit.Models.Enum;
using Microsoft.AspNetCore.Identity;
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
        [Column(TypeName = "varchar(256)")]
        public string Email { get; set; }

        public GenderType Gender { get; set; }

        [Required]
        [Column(TypeName = "varchar(256)")]
        public string Password { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        public int? Height { get; set; }

        public int? Weight { get; set; }

        public string TargetBodyType { get; set; }
    }
}
