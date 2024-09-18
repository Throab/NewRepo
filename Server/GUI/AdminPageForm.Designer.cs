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
            this.ptbUserCtr = new System.Windows.Forms.PictureBox();
            this.ptbMember = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUserCtr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMember = new System.Windows.Forms.Panel();
            this.lblMember = new System.Windows.Forms.Label();
            this.pnlUserCtr = new System.Windows.Forms.Panel();
            this.controlContainer = new System.Windows.Forms.Panel();
            this.userAdminPageControl1 = new Server.GUI.UserAdminPageControl();
            this.memberControl = new Server.GUI.MemberAdminControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUserCtr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlMember.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1078, 78);
            this.panel1.TabIndex = 0;
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBack.Location = new System.Drawing.Point(29, 9);
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
            this.btnClose.Location = new System.Drawing.Point(1045, 9);
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
            this.label1.Location = new System.Drawing.Point(422, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý phòng net";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(104)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.ptbUserCtr);
            this.panel2.Controls.Add(this.ptbMember);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.lblUserCtr);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pnlMember);
            this.panel2.Controls.Add(this.pnlUserCtr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 561);
            this.panel2.TabIndex = 2;
            // 
            // ptbUserCtr
            // 
            this.ptbUserCtr.Image = global::Server.Properties.Resources.bill;
            this.ptbUserCtr.Location = new System.Drawing.Point(38, 356);
            this.ptbUserCtr.Name = "ptbUserCtr";
            this.ptbUserCtr.Size = new System.Drawing.Size(30, 30);
            this.ptbUserCtr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbUserCtr.TabIndex = 15;
            this.ptbUserCtr.TabStop = false;
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
            // lblUserCtr
            // 
            this.lblUserCtr.AutoSize = true;
            this.lblUserCtr.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCtr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserCtr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserCtr.ForeColor = System.Drawing.Color.White;
            this.lblUserCtr.Location = new System.Drawing.Point(74, 363);
            this.lblUserCtr.Name = "lblUserCtr";
            this.lblUserCtr.Size = new System.Drawing.Size(159, 23);
            this.lblUserCtr.TabIndex = 8;
            this.lblUserCtr.Text = "Quản lý nhân viên";
            this.lblUserCtr.Click += new System.EventHandler(this.lblPayment_Click);
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
            // pnlMember
            // 
            this.pnlMember.Controls.Add(this.lblMember);
            this.pnlMember.Location = new System.Drawing.Point(0, 246);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(268, 51);
            this.pnlMember.TabIndex = 18;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.BackColor = System.Drawing.Color.Transparent;
            this.lblMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMember.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.ForeColor = System.Drawing.Color.White;
            this.lblMember.Location = new System.Drawing.Point(73, 8);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(147, 23);
            this.lblMember.TabIndex = 3;
            this.lblMember.Text = "Quản lý hội viên";
            this.lblMember.Click += new System.EventHandler(this.lblMember_Click);
            // 
            // pnlUserCtr
            // 
            this.pnlUserCtr.Location = new System.Drawing.Point(0, 346);
            this.pnlUserCtr.Name = "pnlUserCtr";
            this.pnlUserCtr.Size = new System.Drawing.Size(268, 51);
            this.pnlUserCtr.TabIndex = 20;
            // 
            // controlContainer
            // 
            this.controlContainer.Controls.Add(this.memberControl);
            this.controlContainer.Controls.Add(this.userAdminPageControl1);
            this.controlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlContainer.Location = new System.Drawing.Point(268, 78);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(810, 561);
            this.controlContainer.TabIndex = 3;
            this.controlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.controlContainer_Paint);
            // 
            // userAdminPageControl1
            // 
            this.userAdminPageControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAdminPageControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAdminPageControl1.Location = new System.Drawing.Point(0, 0);
            this.userAdminPageControl1.Name = "userAdminPageControl1";
            this.userAdminPageControl1.Size = new System.Drawing.Size(810, 561);
            this.userAdminPageControl1.TabIndex = 5;
            // 
            // memberControl
            // 
            this.memberControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberControl.Location = new System.Drawing.Point(0, 0);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(810, 561);
            this.memberControl.TabIndex = 2;
            // 
            // AdminPageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1078, 639);
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbUserCtr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlMember.ResumeLayout(false);
            this.pnlMember.PerformLayout();
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
        private System.Windows.Forms.Label lblUserCtr;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox ptbUserCtr;
        private System.Windows.Forms.PictureBox ptbMember;
        private System.Windows.Forms.Label lblBack;
        private GUI.MemberAdminControl memberControl;
        private GUI.UserAdminPageControl userControl;
        private System.Windows.Forms.Panel pnlMember;
        private System.Windows.Forms.Panel pnlUserCtr;
        private GUI.UserAdminPageControl userAdminPageControl1;
    }
}