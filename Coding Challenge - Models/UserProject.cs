using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingChallenge.Models
{
    public class UserProject
    {
        [Key]
        [Column(Order = 1)]
        [Required]
        public int UserId { get; set; }
        [Key]
        [Column(Order = 2)]
        [Required]
        public int ProjectId { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }
        [Required]
        public Boolean IsActive { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; }
    }
}
