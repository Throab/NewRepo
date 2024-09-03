namespace Server.GUI
{
    partial class HomePageFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.PictureBox();
            this.Chat = new System.Windows.Forms.PictureBox();
            this.Request = new System.Windows.Forms.PictureBox();
            this.clientManage = new System.Windows.Forms.PictureBox();
            this.MemberManage = new System.Windows.Forms.PictureBox();
            this.clientHomePageControl1 = new Server.GUI.ClientHomePageControl();
            this.chatControl1 = new Server.GUI.ChatControl();
            this.requestControl1 = new Server.GUI.RequestControl();
            this.memberHomePageControl1 = new Server.GUI.MemberHomePageControl();
            this.panel1.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientManage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberManage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.Chat);
            this.panel1.Controls.Add(this.Request);
            this.panel1.Controls.Add(this.clientManage);
            this.panel1.Controls.Add(this.MemberManage);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 98);
            this.panel1.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(926, 9);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 25);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quản lý máy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quản lý hội viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yêu cầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(729, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đăng xuất";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.clientHomePageControl1);
            this.pnlContainer.Controls.Add(this.chatControl1);
            this.pnlContainer.Controls.Add(this.requestControl1);
            this.pnlContainer.Controls.Add(this.memberHomePageControl1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 98);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(965, 442);
            this.pnlContainer.TabIndex = 1;
            // 
            // back
            // 
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Image = ((System.Drawing.Image)(resources.GetObject("back.Image")));
            this.back.Location = new System.Drawing.Point(29, 24);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(50, 50);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 11;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Logout
            // 
            this.Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.Location = new System.Drawing.Point(749, 13);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(50, 50);
            this.Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logout.TabIndex = 5;
            this.Logout.TabStop = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Chat
            // 
            this.Chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chat.Image = ((System.Drawing.Image)(resources.GetObject("Chat.Image")));
            this.Chat.Location = new System.Drawing.Point(602, 13);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(50, 50);
            this.Chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chat.TabIndex = 4;
            this.Chat.TabStop = false;
            this.Chat.Click += new System.EventHandler(this.Chat_Click);
            // 
            // Request
            // 
            this.Request.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Request.Image = ((System.Drawing.Image)(resources.GetObject("Request.Image")));
            this.Request.Location = new System.Drawing.Point(455, 13);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(50, 50);
            this.Request.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Request.TabIndex = 3;
            this.Request.TabStop = false;
            this.Request.Click += new System.EventHandler(this.Request_Click);
            // 
            // clientManage
            // 
            this.clientManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientManage.Image = ((System.Drawing.Image)(resources.GetObject("clientManage.Image")));
            this.clientManage.Location = new System.Drawing.Point(161, 13);
            this.clientManage.Name = "clientManage";
            this.clientManage.Size = new System.Drawing.Size(50, 50);
            this.clientManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clientManage.TabIndex = 2;
            this.clientManage.TabStop = false;
            this.clientManage.Click += new System.EventHandler(this.clientManage_Click);
            // 
            // MemberManage
            // 
            this.MemberManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MemberManage.Image = ((System.Drawing.Image)(resources.GetObject("MemberManage.Image")));
            this.MemberManage.Location = new System.Drawing.Point(308, 13);
            this.MemberManage.Name = "MemberManage";
            this.MemberManage.Size = new System.Drawing.Size(50, 50);
            this.MemberManage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MemberManage.TabIndex = 1;
            this.MemberManage.TabStop = false;
            this.MemberManage.Click += new System.EventHandler(this.MemberManage_Click);
            // 
            // clientHomePageControl1
            // 
            this.clientHomePageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientHomePageControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientHomePageControl1.Location = new System.Drawing.Point(0, 0);
            this.clientHomePageControl1.Name = "clientHomePageControl1";
            this.clientHomePageControl1.Size = new System.Drawing.Size(965, 442);
            this.clientHomePageControl1.TabIndex = 0;
            // 
            // chatControl1
            // 
            this.chatControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chatControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatControl1.Location = new System.Drawing.Point(0, 0);
            this.chatControl1.Name = "chatControl1";
            this.chatControl1.Size = new System.Drawing.Size(965, 442);
            this.chatControl1.TabIndex = 3;
            // 
            // requestControl1
            // 
            this.requestControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.requestControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestControl1.Location = new System.Drawing.Point(0, 0);
            this.requestControl1.Name = "requestControl1";
            this.requestControl1.Size = new System.Drawing.Size(965, 442);
            this.requestControl1.TabIndex = 2;
            // 
            // memberHomePageControl1
            // 
            this.memberHomePageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberHomePageControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberHomePageControl1.Location = new System.Drawing.Point(0, 0);
            this.memberHomePageControl1.Name = "memberHomePageControl1";
            this.memberHomePageControl1.Size = new System.Drawing.Size(965, 442);
            this.memberHomePageControl1.TabIndex = 1;
            // 
            // HomePageFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(965, 540);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePageFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePageFrm";
            this.Load += new System.EventHandler(this.HomePageFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientManage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.PictureBox clientManage;
        private System.Windows.Forms.PictureBox MemberManage;
        private System.Windows.Forms.PictureBox Chat;
        private System.Windows.Forms.PictureBox Request;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logout;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlContainer;
        private MemberHomePageControl memberHomePageControl1;
        private ClientHomePageControl clientHomePageControl1;
        private ChatControl chatControl1;
        private RequestControl requestControl1;
    }
}