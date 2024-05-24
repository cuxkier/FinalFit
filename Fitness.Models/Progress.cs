using System;
using System.ComponentModel.DataAnnotations;

namespace Fitness.Models
{
    public class Progress
    {
        public int Id { get; set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "Weight must be greater than 0.")]
        public double Weight { get; set; }

        public DateTime Date { get; set; }

        public string UserId { get; set; }
    }
}
