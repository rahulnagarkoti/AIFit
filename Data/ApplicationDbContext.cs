using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NutritionRecommender.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionRecommender.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<Recommendations> Recommendations { get; set; }
        public DbSet<Workout> Workout { get; set; }





    }

}
