using BlazorMessenger.Models;
using DynamicData;

namespace BlazorMessenger.Services
{
    public interface IUserService
    {
        IObservableList<User> GetUsersStream();

        User Login(string username);
    }
}