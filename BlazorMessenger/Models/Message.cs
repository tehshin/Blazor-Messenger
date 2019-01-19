using System;

namespace BlazorMessenger.Models
{
    public class Message
    {
        public string Username { get; set; }

        public string Body { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
