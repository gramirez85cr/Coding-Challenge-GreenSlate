using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.DataModel
{
    public class UserRepository : IUserRepository
    {
        private readonly CodingChallengeContext context;

        public UserRepository(CodingChallengeContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users.ToList();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
