using System;
using System.ComponentModel.DataAnnotations;

namespace CodingChallenge.Models
{
    public class Project
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}
