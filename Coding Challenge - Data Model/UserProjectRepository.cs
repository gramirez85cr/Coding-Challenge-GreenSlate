using CodingChallenge.Models;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.DataModel
{
    public class UserProjectRepository : IUserProjectRepository
    {
        private readonly CodingChallengeContext context;

        public UserProjectRepository(CodingChallengeContext context)
        {
            this.context = context;
        }

        public IEnumerable<UserProject> GetUserProjectsByUserId(int userId)
        {
            using (var context = new CodingChallengeContext())
            {
                return context.UserProject
                    .Include("Project")
                    .Where(up => up.UserId == userId)
                    .ToList();
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
