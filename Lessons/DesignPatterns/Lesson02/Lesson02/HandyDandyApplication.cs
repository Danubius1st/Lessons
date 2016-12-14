using Lesson02.Data;
using Lesson02.Data.SqlServer;
using System.IO;

namespace Lesson02
{
    public class HandyDandyApplication
    {
        private readonly IUserRepository _users;

        public HandyDandyApplication(IUserRepository repository = null)
        {
            _users = repository ?? new UserRepository();
        } 

        public void DisplayUsers(TextWriter writer)
        {
            foreach (var user in _users.All())
            {
                //var userData = string.Format("{0}\t{1} {2}", user.Id, user.FirstName, user.LastName);

                var userData = $"{user.Id}\t{user.FirstName} {user.LastName}";  // string interpolation expression

                writer.WriteLineAsync(userData);
            }
        }
    }
}
