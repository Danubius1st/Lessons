using System.Collections.Generic;

namespace Lesson02.Data
{
    public interface IUserRepository
    {
        IEnumerable<User> All();
    }
}