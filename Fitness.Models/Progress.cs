using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public string UserId { get; set; } // Identyfikator użytkownika

        // Powiązanie z użytkownikiem
        public ApplicationUser User { get; set; }
    }
}
