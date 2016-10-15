using System.Net;

namespace ChatClient
{
    public class ChatMessage
    {
        public IPAddress Ip { get; set; }
        public string Message { get; set; }
    }
}