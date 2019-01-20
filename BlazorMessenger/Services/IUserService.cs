using BlazorMessenger.Models;
using DynamicData;
using System;

namespace BlazorMessenger.Services
{
    public interface IUserService
    {
        IObservableList<User> GetUsersStream();

        IObservable<User> GetUserUpdateStream(string username);

        User Login(string username);

        void MuteUser(string username);

        void UnmuteUser(string username);
    }
}