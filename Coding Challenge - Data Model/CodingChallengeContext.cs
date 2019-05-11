using System.Data.Entity;
using CodingChallenge.Models;

namespace CodingChallenge.DataModel
{
    public class CodingChallengeContext : DbContext
    {
        public CodingChallengeContext() : base("DefaultConnection") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<UserProject> UserProject { get; set; }
    }
}
