using BlazorMessenger.Models;
using DynamicData;
using System.Linq;

namespace BlazorMessenger.Services
{
    public class UserService : IUserService
    {
        private readonly SourceList<User> _usersSource = new SourceList<User>();

        public User Login(string username)
        {
            if (_usersSource.Items.Any(u => string.Equals(u.Username, username)))
            {
                return null;
            }

            var user = new User
            {
                Username = username,
                IsMuted = false
            };

            _usersSource.Add(user);

            return user;
        }

        public IObservableList<User> GetUsersStream()
        {
            return _usersSource.AsObservableList();
        }
    }
}
