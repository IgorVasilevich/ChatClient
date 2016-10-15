using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatClient
{
    public enum Requests
    {
        Join = 1,
        GetMessages = 2,
        Leave = 3,
        SendMessage = 4,
        LogIn = 5,
        Reg = 6,
        NotLogIn = 7,
        NotReg = 8,
        GetUsers = 9,
        PrivateMessage = 10
    }


    public class ChatClient
    {
        private TcpClient client;
        private BinaryReader reader;
        private BinaryWriter writer;

        public event Action<ChatClient, IEnumerable<ChatMessage>> MessageReceived;
        public event Action<string, string, string> PrivateMessageReceived;
        public event Action<ChatClient, List<string>> OnGetUsersOnline;

        public ChatClient(IPEndPoint point)
        {

            client = new TcpClient();
            client.Connect(point);
            var stream = client.GetStream();
            reader = new BinaryReader(stream);
            writer = new BinaryWriter(stream);
        }

        public void Join()
        {
            writer.Write((int)Requests.Join);
            writer.Flush();

            ThreadPool.QueueUserWorkItem(ClientProc);
        }


        public void Leave(string User)
        {
            writer.Write((int)Requests.Leave);
            writer.Write(User);
            writer.Flush();
        }

        public void SendMessage(string message)
        {
            writer.Write((int)Requests.SendMessage);
            writer.Write(message);
            writer.Flush();
        }
        private void ClientProc(object state)
        {
            while (true)
            {

                var command = (Requests)reader.ReadInt32();
                switch (command)
                {
                    case Requests.GetMessages:
                        OnGetMessages(reader);
                        break;
                    case Requests.NotLogIn:
                        throw new Exception();
                        break;
                    case Requests.NotReg:
                        throw new Exception();
                        break;
                    case Requests.PrivateMessage:
                        OnGetPrivateMessage(reader);
                        break;
                    case Requests.GetUsers:
                        OnGetUsers(reader);
                        break;


                }
            }
        }

        private void OnGetUsers(BinaryReader reader)
        {
            List<string> users = new List<string>();

            int n = reader.ReadInt32();
            for (int i = 0; i < n; i++)
            {
                users.Add(reader.ReadString().ToString());
            }

            OnGetUsersOnline?.Invoke(this, users);
        }

        private void OnGetPrivateMessage(BinaryReader reader)
        {
            string userSent = reader.ReadString();
            string userReceived = reader.ReadString();
            string message = reader.ReadString();

            PrivateMessageReceived?.Invoke(userSent, userReceived, message);
        }

        private void OnGetMessages(BinaryReader reader)
        {
            List<ChatMessage> result = new List<ChatMessage>();

            int n = reader.ReadInt32();
            for (int i = 0; i < n; i++)
            {
                result.Add(ReadChatMessage(reader));
            }

            MessageReceived?.Invoke(this, result);
        }

        private ChatMessage ReadChatMessage(BinaryReader reader)
        {
            return new ChatMessage()
            {
                Message = reader.ReadString()
            };
        }

        public void GetMessages()
        {
            writer.Write((int)Requests.GetMessages);
            writer.Flush();
        }

        public void SendPrivateMessage(string UserSend, string UserReceived, string message)
        {
            writer.Write((int)Requests.PrivateMessage);
            writer.Flush();
            writer.Write(UserSend);
            writer.Write(UserReceived);
            writer.Write(message);
            writer.Flush();
        }

        public void LogIn(string login, string password)
        {
            writer.Write((int)Requests.LogIn);
            writer.Write(login);
            writer.Flush();
            writer.Write(password);
            writer.Flush();
        }
        public void Reg(string login, string password)
        {
            writer.Write((int)Requests.Reg);
            writer.Write(login);
            writer.Flush();
            writer.Write(password);
            writer.Flush();
        }
    }
}
