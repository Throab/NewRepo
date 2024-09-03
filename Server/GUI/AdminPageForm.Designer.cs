namespace Server
{
    partial class AdminPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbPayment = new System.Windows.Forms.PictureBox();
            this.ptbMenu = new System.Windows.Forms.PictureBox();
            this.ptbMember = new System.Windows.Forms.PictureBox();
            this.ptbClient = new System.Windows.Forms.PictureBox();
            this.ptbMainPage = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblMainPage = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblClientPage = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMainPage = new System.Windows.Forms.Panel();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.controlContainer = new System.Windows.Forms.Panel();
            this.dashBoardControl1 = new Server.GUI.DashBoardControl();
            this.dashBoardControl = new Server.GUI.DashBoardControl();
            this.menuControl = new Server.GUI.MenuControl();
            this.memberControl = new Server.GUI.MemberAdminControl();
            this.clientControl = new Server.GUI.ClientAdminControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMainPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(70)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.lblBack);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBack.Location = new System.Drawing.Point(12, 18);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(44, 42);
            this.lblBack.TabIndex = 3;
            this.lblBack.Text = "◀";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(945, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 25);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(351, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng net";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.ptbPayment);
            this.panel2.Controls.Add(this.ptbMenu);
            this.panel2.Controls.Add(this.ptbMember);
            this.panel2.Controls.Add(this.ptbClient);
            this.panel2.Controls.Add(this.ptbMainPage);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.lblPayment);
            this.panel2.Controls.Add(this.lblMainPage);
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Controls.Add(this.lblClientPage);
            this.panel2.Controls.Add(this.lblMember);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pnlMainPage);
            this.panel2.Controls.Add(this.pnlClient);
            this.panel2.Controls.Add(this.pnlMember);
            this.panel2.Controls.Add(this.pnlMenu);
            this.panel2.Controls.Add(this.pnlPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 497);
            this.panel2.TabIndex = 2;
            // 
            // ptbPayment
            // 
            this.ptbPayment.Image = global::Server.Properties.Resources.bill;
            this.ptbPayment.Location = new System.Drawing.Point(38, 356);
            this.ptbPayment.Name = "ptbPayment";
            this.ptbPayment.Size = new System.Drawing.Size(30, 30);
            this.ptbPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPayment.TabIndex = 15;
            this.ptbPayment.TabStop = false;
            // 
            // ptbMenu
            // 
            this.ptbMenu.Image = global::Server.Properties.Resources.menu;
            this.ptbMenu.Location = new System.Drawing.Point(38, 304);
            this.ptbMenu.Name = "ptbMenu";
            this.ptbMenu.Size = new System.Drawing.Size(30, 30);
            this.ptbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMenu.TabIndex = 14;
            this.ptbMenu.TabStop = false;
            // 
            // ptbMember
            // 
            this.ptbMember.Image = global::Server.Properties.Resources.user;
            this.ptbMember.Location = new System.Drawing.Point(38, 254);
            this.ptbMember.Name = "ptbMember";
            this.ptbMember.Size = new System.Drawing.Size(30, 30);
            this.ptbMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMember.TabIndex = 13;
            this.ptbMember.TabStop = false;
            // 
            // ptbClient
            // 
            this.ptbClient.Image = global::Server.Properties.Resources.computer;
            this.ptbClient.Location = new System.Drawing.Point(38, 204);
            this.ptbClient.Name = "ptbClient";
            this.ptbClient.Size = new System.Drawing.Size(30, 30);
            this.ptbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbClient.TabIndex = 12;
            this.ptbClient.TabStop = false;
            // 
            // ptbMainPage
            // 
            this.ptbMainPage.Image = global::Server.Properties.Resources.home;
            this.ptbMainPage.Location = new System.Drawing.Point(38, 154);
            this.ptbMainPage.Name = "ptbMainPage";
            this.ptbMainPage.Size = new System.Drawing.Size(30, 30);
            this.ptbMainPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMainPage.TabIndex = 0;
            this.ptbMainPage.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(54)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(66, 415);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(136, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPayment.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.White;
            this.lblPayment.Location = new System.Drawing.Point(74, 363);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(166, 23);
            this.lblPayment.TabIndex = 8;
            this.lblPayment.Text = "Quản lý thanh toán";
            // 
            // lblMainPage
            // 
            this.lblMainPage.AutoSize = true;
            this.lblMainPage.BackColor = System.Drawing.Color.Transparent;
            this.lblMainPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainPage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainPage.ForeColor = System.Drawing.Color.White;
            this.lblMainPage.Location = new System.Drawing.Point(74, 161);
            this.lblMainPage.Name = "lblMainPage";
            this.lblMainPage.Size = new System.Drawing.Size(130, 23);
            this.lblMainPage.TabIndex = 7;
            this.lblMainPage.Text = "Quản lý chung";
            this.lblMainPage.Click += new System.EventHandler(this.lblMainPage_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(74, 311);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(153, 23);
            this.lblMenu.TabIndex = 6;
            this.lblMenu.Text = "Quản lý thực đơn";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // lblClientPage
            // 
            this.lblClientPage.AutoSize = true;
            this.lblClientPage.BackColor = System.Drawing.Color.Transparent;
            this.lblClientPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientPage.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPage.ForeColor = System.Drawing.Color.White;
            this.lblClientPage.Location = new System.Drawing.Point(74, 211);
            this.lblClientPage.Name = "lblClientPage";
            this.lblClientPage.Size = new System.Drawing.Size(114, 23);
            this.lblClientPage.TabIndex = 5;
            this.lblClientPage.Text = "Quản lý máy";
            this.lblClientPage.Click += new System.EventHandler(this.lblClientPage_Click);
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.BackColor = System.Drawing.Color.Transparent;
            this.lblMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMember.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.ForeColor = System.Drawing.Color.White;
            this.lblMember.Location = new System.Drawing.Point(74, 261);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(147, 23);
            this.lblMember.TabIndex = 3;
            this.lblMember.Text = "Quản lý hội viên";
            this.lblMember.Click += new System.EventHandler(this.lblMember_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Server.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(71, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnlMainPage
            // 
            this.pnlMainPage.Location = new System.Drawing.Point(0, 146);
            this.pnlMainPage.Name = "pnlMainPage";
            this.pnlMainPage.Size = new System.Drawing.Size(268, 51);
            this.pnlMainPage.TabIndex = 16;
            // 
            // pnlClient
            // 
            this.pnlClient.Location = new System.Drawing.Point(0, 196);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(268, 51);
            this.pnlClient.TabIndex = 17;
            // 
            // pnlMember
            // 
            this.pnlMember.Location = new System.Drawing.Point(0, 246);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(268, 51);
            this.pnlMember.TabIndex = 18;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 296);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(268, 51);
            this.pnlMenu.TabIndex = 19;
            // 
            // pnlPayment
            // 
            this.pnlPayment.Location = new System.Drawing.Point(0, 346);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(268, 51);
            this.pnlPayment.TabIndex = 20;
            // 
            // controlContainer
            // 
            this.controlContainer.Controls.Add(this.dashBoardControl1);
            this.controlContainer.Controls.Add(this.dashBoardControl);
            this.controlContainer.Controls.Add(this.menuControl);
            this.controlContainer.Controls.Add(this.memberControl);
            this.controlContainer.Controls.Add(this.clientControl);
            this.controlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainer.Location = new System.Drawing.Point(268, 78);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(710, 497);
            this.controlContainer.TabIndex = 3;
            this.controlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.controlContainer_Paint);
            // 
            // dashBoardControl1
            // 
            this.dashBoardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardControl1.Location = new System.Drawing.Point(0, 0);
            this.dashBoardControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashBoardControl1.Name = "dashBoardControl1";
            this.dashBoardControl1.Size = new System.Drawing.Size(710, 497);
            this.dashBoardControl1.TabIndex = 4;
            // 
            // dashBoardControl
            // 
            this.dashBoardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardControl.Location = new System.Drawing.Point(0, 0);
            this.dashBoardControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashBoardControl.Name = "dashBoardControl";
            this.dashBoardControl.Size = new System.Drawing.Size(710, 497);
            this.dashBoardControl.TabIndex = 0;
            // 
            // menuControl
            // 
            this.menuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.Name = "menuControl";
            this.menuControl.Size = new System.Drawing.Size(710, 497);
            this.menuControl.TabIndex = 3;
            // 
            // memberControl
            // 
            this.memberControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberControl.Location = new System.Drawing.Point(0, 0);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(710, 497);
            this.memberControl.TabIndex = 2;
            // 
            // clientControl
            // 
            this.clientControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientControl.Location = new System.Drawing.Point(0, 0);
            this.clientControl.Name = "clientControl";
            this.clientControl.Size = new System.Drawing.Size(710, 497);
            this.clientControl.TabIndex = 1;
            // 
            // AdminPageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(978, 575);
            this.ControlBox = false;
            this.Controls.Add(this.controlContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMainPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Panel controlContainer;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblClientPage;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblMainPage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox ptbMainPage;
        private System.Windows.Forms.PictureBox ptbPayment;
        private System.Windows.Forms.PictureBox ptbMenu;
        private System.Windows.Forms.PictureBox ptbMember;
        private System.Windows.Forms.PictureBox ptbClient;
        private System.Windows.Forms.Label lblBack;
        private GUI.ClientAdminControl clientControl;
        private GUI.DashBoardControl dashBoardControl;
        private GUI.MenuControl menuControl;
        private GUI.MemberAdminControl memberControl;
        private System.Windows.Forms.Panel pnlMainPage;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlPayment;
        private GUI.DashBoardControl dashBoardControl1;
    }
}