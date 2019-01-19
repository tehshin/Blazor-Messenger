using BlazorMessenger.Models;
using System;

namespace BlazorMessenger.Services
{
    public interface IMessageService
    {
        void SendMessage(string username, string message);

        IObservable<Message> GetMessageStream();
    }
}
