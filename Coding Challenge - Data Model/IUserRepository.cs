using CodingChallenge.Models;
using System;
using System.Collections.Generic;

namespace CodingChallenge.DataModel
{
    public interface IUserRepository : IDisposable
    {
        IEnumerable<User> GetAllUsers();
    }
}
