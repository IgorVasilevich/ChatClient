using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class ChatMainForm : Form
    {
        private ChatClient client;

        public ChatMainForm()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            string text = tbIpEndPoint.Text;
            var parts = text.Split(':');
            if (parts.Length != 2)
            {
                MessageBox.Show("Enter IP:port");
                return;
            }

            string ip = parts[0];
            var ipParts = ip.Split('.');
            if (ipParts.Length != 4)
            {
                MessageBox.Show("Ip is incorrect");
                return;
            }

            IPAddress ipResult;

            if (!IPAddress.TryParse(ip, out ipResult))
            {
                MessageBox.Show("One or more parts of ip is wrong!");
                return;
            }


            string port = parts[1];
            int iPort;
            if (!int.TryParse(port, out iPort) || iPort <= 0 || iPort >= ushort.MaxValue)
            {
                MessageBox.Show("Port is incorrect");
            }

            IPEndPoint ipep = new IPEndPoint(ipResult, iPort);
            client = new ChatClient(ipep);
            client.Join();
            client.MessageReceived += Cliet_MessagesReceived;
            client.PrivateMessageReceived += CLient_PrivateMessageReceived;
            client.OnGetUsersOnline += GetUsers;
            JoinUI();
        }

        private void JoinUI()
        {
            btConnect.Enabled = false;
            btConnect.Text = "Connected";
            tbIpEndPoint.Enabled = false;
            btLogIn.Visible = true;
            tlLogin.Visible = true;
            tbLogIn.Visible = true;
            mTbPassLog.Visible = true;
            ltPassLog.Visible = true;
            btReg.Visible = true;
            tbReg.Visible = true;
            ltOR.Visible = true;
            lbReg.Visible = true;
            mTbPassReg.Visible = true;
            ltPassReg.Visible = true;
        }

        private void CLient_PrivateMessageReceived(string UserSend, string UserReceived, string message)
        {
            if (UserReceived == tbLogIn.Text.ToString())
            {
                MessageBox.Show($"Message from  user: {UserSend} :  {message}");
            }
        }

        private void Cliet_MessagesReceived(ChatClient client, IEnumerable<ChatMessage> messages)
        {

            tbMessages.BeginInvoke(new Action(() =>
            {
                StringBuilder builder = new StringBuilder(tbMessages.Text);
                foreach (var item in messages)
                {
                    builder.AppendLine($"{item.Message}");
                }
                tbMessages.AppendText(builder.ToString());
            }));
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Leave(tbLogIn.Text);
        }

        private void btSendMessage_Click(object sender, EventArgs e)
        {
            string message = DateTime.Now.ToString() + "|   " + tbLogIn.Text + "|     " + tbMessage.Text;
            client.SendMessage(message);
            tbMessage.Text = "";
            tbMessages.Text = "";
            client.GetMessages();
        }

        private void tbMessages_Click(object sender, EventArgs e)
        {
            client.GetMessages();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                client.LogIn(tbLogIn.Text, mTbPassLog.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Login! Please try one more time");
            }
            LogInUI();
        }

        private void LogInUI()
        {
            mTbPassLog.Visible = false;
            btLogIn.Visible = false;
            tbLogIn.Enabled = false;
            tlLogin.Enabled = false;
            ltPassLog.Visible = false;
            btReg.Visible = false;
            mTbPassReg.Visible = false;
            tbReg.Visible = false;
            ltOR.Visible = false;
            lbReg.Visible = false;
            ltPassReg.Visible = false;
            ltSendPM.Visible = true;
            ltPrivatMessage.Visible = true;
            ltToUserPM.Visible = true;
            tbUserReceived.Visible = true;
            tbUserReceiveMessage.Visible = true;
            btPrivateMess.Visible = true;
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            try
            {
                client.Reg(tbReg.Text, mTbPassReg.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Login is already exist");
            }
            RegUI();
        }

        private void RegUI()
        {
            btReg.Visible = false;
            tbReg.Visible = false;
            ltOR.Visible = false;
            lbReg.Visible = false;
            ltPassReg.Visible = false;
        }

        public void GetUsers(ChatClient client, List<string> users)
        {
            tbUsersOnline.BeginInvoke(new Action(() =>
            {
                StringBuilder builder = new StringBuilder();
                foreach (var item in users)
                {
                    builder.AppendLine(item);
                }
                tbUsersOnline.AppendText(builder.ToString());
            }));

        }

        private void btPrivMess_Click(object sender, EventArgs e)
        {
            client.SendPrivateMessage(tbLogIn.Text, tbUserReceived.Text, tbUserReceiveMessage.Text);
        }
    }
}
