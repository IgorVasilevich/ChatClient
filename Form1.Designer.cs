namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btConnect = new System.Windows.Forms.Button();
            this.tbIpEndPoint = new System.Windows.Forms.TextBox();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSendMessage = new System.Windows.Forms.Button();
            this.tbLogIn = new System.Windows.Forms.TextBox();
            this.btLogIn = new System.Windows.Forms.Button();
            this.tlLogin = new System.Windows.Forms.Label();
            this.tbReg = new System.Windows.Forms.TextBox();
            this.lbReg = new System.Windows.Forms.Label();
            this.btReg = new System.Windows.Forms.Button();
            this.ltOR = new System.Windows.Forms.Label();
            this.mTbPassReg = new System.Windows.Forms.MaskedTextBox();
            this.mTbPassLog = new System.Windows.Forms.MaskedTextBox();
            this.ltPassLog = new System.Windows.Forms.Label();
            this.ltPassReg = new System.Windows.Forms.Label();
            this.tbUserReceived = new System.Windows.Forms.TextBox();
            this.tbUserReceiveMessage = new System.Windows.Forms.TextBox();
            this.ltSendPM = new System.Windows.Forms.Label();
            this.ltToUserPM = new System.Windows.Forms.Label();
            this.ltPrivatMessage = new System.Windows.Forms.Label();
            this.btPrivateMess = new System.Windows.Forms.Button();
            this.tbUsersOnline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(976, 1);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(109, 35);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbIpEndPoint
            // 
            this.tbIpEndPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpEndPoint.Location = new System.Drawing.Point(816, 1);
            this.tbIpEndPoint.Name = "tbIpEndPoint";
            this.tbIpEndPoint.Size = new System.Drawing.Size(164, 35);
            this.tbIpEndPoint.TabIndex = 1;
            this.tbIpEndPoint.Text = "127.0.0.1:8009";
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(12, 1);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.Size = new System.Drawing.Size(795, 425);
            this.tbMessages.TabIndex = 2;
            this.tbMessages.Click += new System.EventHandler(this.tbMessages_Click);
            this.tbMessages.TextChanged += new System.EventHandler(this.tbMessages_TextChanged);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 463);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(661, 48);
            this.tbMessage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type message";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btSendMessage
            // 
            this.btSendMessage.Location = new System.Drawing.Point(679, 463);
            this.btSendMessage.Name = "btSendMessage";
            this.btSendMessage.Size = new System.Drawing.Size(128, 48);
            this.btSendMessage.TabIndex = 5;
            this.btSendMessage.Text = "SEND";
            this.btSendMessage.UseMnemonic = false;
            this.btSendMessage.UseVisualStyleBackColor = true;
            this.btSendMessage.Click += new System.EventHandler(this.btSendMessage_Click);
            // 
            // tbLogIn
            // 
            this.tbLogIn.Location = new System.Drawing.Point(816, 55);
            this.tbLogIn.Name = "tbLogIn";
            this.tbLogIn.Size = new System.Drawing.Size(88, 20);
            this.tbLogIn.TabIndex = 6;
            this.tbLogIn.Visible = false;
            // 
            // btLogIn
            // 
            this.btLogIn.Location = new System.Drawing.Point(1010, 55);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(75, 23);
            this.btLogIn.TabIndex = 7;
            this.btLogIn.Text = "LogIn";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Visible = false;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // tlLogin
            // 
            this.tlLogin.AutoSize = true;
            this.tlLogin.Location = new System.Drawing.Point(813, 39);
            this.tlLogin.Name = "tlLogin";
            this.tlLogin.Size = new System.Drawing.Size(62, 13);
            this.tlLogin.TabIndex = 8;
            this.tlLogin.Text = "Login name";
            this.tlLogin.Visible = false;
            // 
            // tbReg
            // 
            this.tbReg.Location = new System.Drawing.Point(816, 111);
            this.tbReg.Name = "tbReg";
            this.tbReg.Size = new System.Drawing.Size(88, 20);
            this.tbReg.TabIndex = 9;
            this.tbReg.Visible = false;
            // 
            // lbReg
            // 
            this.lbReg.AutoSize = true;
            this.lbReg.Location = new System.Drawing.Point(813, 95);
            this.lbReg.Name = "lbReg";
            this.lbReg.Size = new System.Drawing.Size(63, 13);
            this.lbReg.TabIndex = 10;
            this.lbReg.Text = "Registration";
            this.lbReg.Visible = false;
            // 
            // btReg
            // 
            this.btReg.Location = new System.Drawing.Point(1010, 111);
            this.btReg.Name = "btReg";
            this.btReg.Size = new System.Drawing.Size(75, 23);
            this.btReg.TabIndex = 11;
            this.btReg.Text = "Registration";
            this.btReg.UseVisualStyleBackColor = true;
            this.btReg.Visible = false;
            this.btReg.Click += new System.EventHandler(this.btReg_Click);
            // 
            // ltOR
            // 
            this.ltOR.AutoSize = true;
            this.ltOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltOR.Location = new System.Drawing.Point(813, 78);
            this.ltOR.Name = "ltOR";
            this.ltOR.Size = new System.Drawing.Size(31, 17);
            this.ltOR.TabIndex = 12;
            this.ltOR.Text = "OR";
            this.ltOR.Visible = false;
            // 
            // mTbPassReg
            // 
            this.mTbPassReg.Location = new System.Drawing.Point(910, 111);
            this.mTbPassReg.Name = "mTbPassReg";
            this.mTbPassReg.PasswordChar = '*';
            this.mTbPassReg.Size = new System.Drawing.Size(93, 20);
            this.mTbPassReg.TabIndex = 14;
            this.mTbPassReg.Visible = false;
            // 
            // mTbPassLog
            // 
            this.mTbPassLog.Location = new System.Drawing.Point(911, 55);
            this.mTbPassLog.Name = "mTbPassLog";
            this.mTbPassLog.PasswordChar = '*';
            this.mTbPassLog.Size = new System.Drawing.Size(93, 20);
            this.mTbPassLog.TabIndex = 15;
            this.mTbPassLog.Visible = false;
            // 
            // ltPassLog
            // 
            this.ltPassLog.AutoSize = true;
            this.ltPassLog.Location = new System.Drawing.Point(908, 39);
            this.ltPassLog.Name = "ltPassLog";
            this.ltPassLog.Size = new System.Drawing.Size(53, 13);
            this.ltPassLog.TabIndex = 16;
            this.ltPassLog.Text = "Password";
            this.ltPassLog.Visible = false;
            // 
            // ltPassReg
            // 
            this.ltPassReg.AutoSize = true;
            this.ltPassReg.Location = new System.Drawing.Point(908, 95);
            this.ltPassReg.Name = "ltPassReg";
            this.ltPassReg.Size = new System.Drawing.Size(53, 13);
            this.ltPassReg.TabIndex = 17;
            this.ltPassReg.Text = "Password";
            this.ltPassReg.Visible = false;
            // 
            // tbUserReceived
            // 
            this.tbUserReceived.Location = new System.Drawing.Point(838, 413);
            this.tbUserReceived.Name = "tbUserReceived";
            this.tbUserReceived.Size = new System.Drawing.Size(100, 20);
            this.tbUserReceived.TabIndex = 19;
            this.tbUserReceived.Visible = false;
            // 
            // tbUserReceiveMessage
            // 
            this.tbUserReceiveMessage.Location = new System.Drawing.Point(838, 453);
            this.tbUserReceiveMessage.Multiline = true;
            this.tbUserReceiveMessage.Name = "tbUserReceiveMessage";
            this.tbUserReceiveMessage.Size = new System.Drawing.Size(218, 58);
            this.tbUserReceiveMessage.TabIndex = 20;
            this.tbUserReceiveMessage.Visible = false;
            // 
            // ltSendPM
            // 
            this.ltSendPM.AutoSize = true;
            this.ltSendPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ltSendPM.Location = new System.Drawing.Point(835, 366);
            this.ltSendPM.Name = "ltSendPM";
            this.ltSendPM.Size = new System.Drawing.Size(164, 16);
            this.ltSendPM.TabIndex = 21;
            this.ltSendPM.Text = "Send private message";
            this.ltSendPM.Visible = false;
            // 
            // ltToUserPM
            // 
            this.ltToUserPM.AutoSize = true;
            this.ltToUserPM.Location = new System.Drawing.Point(837, 397);
            this.ltToUserPM.Name = "ltToUserPM";
            this.ltToUserPM.Size = new System.Drawing.Size(39, 13);
            this.ltToUserPM.TabIndex = 22;
            this.ltToUserPM.Text = "to user";
            this.ltToUserPM.Visible = false;
            // 
            // ltPrivatMessage
            // 
            this.ltPrivatMessage.AutoSize = true;
            this.ltPrivatMessage.Location = new System.Drawing.Point(841, 437);
            this.ltPrivatMessage.Name = "ltPrivatMessage";
            this.ltPrivatMessage.Size = new System.Drawing.Size(50, 13);
            this.ltPrivatMessage.TabIndex = 23;
            this.ltPrivatMessage.Text = "Message";
            this.ltPrivatMessage.Visible = false;
            // 
            // btPrivateMess
            // 
            this.btPrivateMess.Location = new System.Drawing.Point(962, 413);
            this.btPrivateMess.Name = "btPrivateMess";
            this.btPrivateMess.Size = new System.Drawing.Size(94, 37);
            this.btPrivateMess.TabIndex = 24;
            this.btPrivateMess.Text = "Send private message";
            this.btPrivateMess.UseVisualStyleBackColor = true;
            this.btPrivateMess.Visible = false;
            this.btPrivateMess.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbUsersOnline
            // 
            this.tbUsersOnline.Location = new System.Drawing.Point(816, 196);
            this.tbUsersOnline.Multiline = true;
            this.tbUsersOnline.Name = "tbUsersOnline";
            this.tbUsersOnline.ReadOnly = true;
            this.tbUsersOnline.Size = new System.Drawing.Size(269, 153);
            this.tbUsersOnline.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 535);
            this.Controls.Add(this.tbUsersOnline);
            this.Controls.Add(this.btPrivateMess);
            this.Controls.Add(this.ltPrivatMessage);
            this.Controls.Add(this.ltToUserPM);
            this.Controls.Add(this.ltSendPM);
            this.Controls.Add(this.tbUserReceiveMessage);
            this.Controls.Add(this.tbUserReceived);
            this.Controls.Add(this.ltPassReg);
            this.Controls.Add(this.ltPassLog);
            this.Controls.Add(this.mTbPassLog);
            this.Controls.Add(this.mTbPassReg);
            this.Controls.Add(this.ltOR);
            this.Controls.Add(this.btReg);
            this.Controls.Add(this.lbReg);
            this.Controls.Add(this.tbReg);
            this.Controls.Add(this.tlLogin);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.tbLogIn);
            this.Controls.Add(this.btSendMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.tbIpEndPoint);
            this.Controls.Add(this.btConnect);
            this.Name = "Form1";
            this.Text = "Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox tbIpEndPoint;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSendMessage;
        private System.Windows.Forms.TextBox tbLogIn;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Label tlLogin;
        private System.Windows.Forms.TextBox tbReg;
        private System.Windows.Forms.Label lbReg;
        private System.Windows.Forms.Button btReg;
        private System.Windows.Forms.Label ltOR;
        private System.Windows.Forms.MaskedTextBox mTbPassReg;
        private System.Windows.Forms.MaskedTextBox mTbPassLog;
        private System.Windows.Forms.Label ltPassLog;
        private System.Windows.Forms.Label ltPassReg;
        private System.Windows.Forms.TextBox tbUserReceived;
        private System.Windows.Forms.TextBox tbUserReceiveMessage;
        private System.Windows.Forms.Label ltSendPM;
        private System.Windows.Forms.Label ltToUserPM;
        private System.Windows.Forms.Label ltPrivatMessage;
        private System.Windows.Forms.Button btPrivateMess;
        private System.Windows.Forms.TextBox tbUsersOnline;
    }
}

