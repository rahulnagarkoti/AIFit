using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIFit.Data.ViewModels
{
    public class SuggestionViewModel
    {
        public int WorkoutId { get; set; }
        public string ExerciseName { get; set; }
        public float TotalTime { get; set; }
        public float TotalBurn { get; set; }

    }
}
