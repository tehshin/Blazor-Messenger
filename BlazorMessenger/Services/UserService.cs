using BlazorMessenger.Models;
using DynamicData;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace BlazorMessenger.Services
{
    public class UserService : IUserService
    {
        private readonly SourceList<User> _usersSource = new SourceList<User>();
        private readonly Subject<User> _userUpdatedSubject = new Subject<User>();

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

        public IObservable<User> GetUserUpdateStream(string username)
        {
            return _userUpdatedSubject
                .Where(u => string.Equals(u.Username, username))
                .AsObservable();
        }

        public void MuteUser(string username)
        {
            SetUserMuteStatus(username, true);
        }

        public void UnmuteUser(string username)
        {
            SetUserMuteStatus(username, false);
        }

        private void SetUserMuteStatus(string username, bool isMuted)
        {
            var user = _usersSource.Items.FirstOrDefault(u => string.Equals(u.Username, username));
            if (user == null) return;

            user.IsMuted = isMuted;
            _usersSource.Replace(user, user);
            _userUpdatedSubject.OnNext(user);
        }
    }
}
