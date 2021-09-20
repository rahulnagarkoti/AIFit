using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIFit.Data.ViewModels
{
    public class ApiResponse
    {
        public int WorkoutId { get; set; }
        public int StatusCode { get; set; }
    }
    public class CustomerData
    {
        public decimal weight { get; set; }
        public decimal height { get; set; }
        public int bodyType { get; set; }
        public int gender { get; set; }
    }
}
