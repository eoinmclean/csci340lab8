using System;
using System.ComponentModel.DataAnnotations;

namespace RazorApp.Models
{
    public class Workout
    {
        public int Id { get; set; }

        [Required]
        public string Exercise { get; set; }

        [Range(0, 1000)]
        public int Weight { get; set; }

        [Range(1, 100)]
        public int Reps { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}