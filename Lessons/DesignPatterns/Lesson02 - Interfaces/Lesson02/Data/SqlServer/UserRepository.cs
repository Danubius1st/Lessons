using System.Collections.Generic;

namespace Lesson02.Data.SqlServer
{
    /// <summary>
    /// This isn't a real SqlServer repository
    /// </summary>
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _store;

        static UserRepository()
        {
            _store = new List<User>(new[]
            {
                new User { Id = 1, FirstName = "John", LastName = "Doe" },
                new User { Id = 2, FirstName = "James", LastName = "Doe" },
                new User { Id = 3, FirstName = "Jane", LastName = "Doe" },
                new User { Id = 4, FirstName = "Jennifer", LastName = "Doe" }
            });
        }

        public IEnumerable<User> All()
        {
            return _store.ToArray();
        }
    }
}
