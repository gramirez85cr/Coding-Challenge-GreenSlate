using CodingChallenge.Models;
using System;
using System.Collections.Generic;

namespace CodingChallenge.DataModel
{
    public interface IUserProjectRepository : IDisposable
    {
        IEnumerable<UserProject> GetUserProjectsByUserId(int userId);
    }
}
