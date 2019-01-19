using BlazorMessenger.Models;
using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace BlazorMessenger.Services
{
    public class MessageService : IMessageService
    {
        private readonly Subject<Message> _messageBus = new Subject<Message>();

        public IObservable<Message> GetMessageStream()
        {
            return _messageBus.AsObservable();
        }

        public void SendMessage(string username, string message)
        {
            _messageBus.OnNext(new Message
            {
                Username = username,
                Body = message,
                Timestamp = DateTime.Now
            });
        }
    }
}
