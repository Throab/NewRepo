namespace Server.GUI
{
    partial class MemberControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMember = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuuHV = new System.Windows.Forms.Button();
            this.btnXoaHV = new System.Windows.Forms.Button();
            this.btnSuaHV = new System.Windows.Forms.Button();
            this.btnThemHV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nbMoney = new System.Windows.Forms.NumericUpDown();
            this.cbGroupUser = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvMember);
            this.panel1.Location = new System.Drawing.Point(26, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 216);
            this.panel1.TabIndex = 0;
            // 
            // dtgvMember
            // 
            this.dtgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMember.Location = new System.Drawing.Point(3, 6);
            this.dtgvMember.Name = "dtgvMember";
            this.dtgvMember.RowHeadersWidth = 51;
            this.dtgvMember.RowTemplate.Height = 24;
            this.dtgvMember.Size = new System.Drawing.Size(796, 200);
            this.dtgvMember.TabIndex = 0;
            this.dtgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMember_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuuHV);
            this.panel2.Controls.Add(this.btnXoaHV);
            this.panel2.Controls.Add(this.btnSuaHV);
            this.panel2.Controls.Add(this.btnThemHV);
            this.panel2.Location = new System.Drawing.Point(26, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 104);
            this.panel2.TabIndex = 1;
            // 
            // btnLuuHV
            // 
            this.btnLuuHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuuHV.Location = new System.Drawing.Point(575, 31);
            this.btnLuuHV.Name = "btnLuuHV";
            this.btnLuuHV.Size = new System.Drawing.Size(146, 45);
            this.btnLuuHV.TabIndex = 3;
            this.btnLuuHV.Text = "Lưu";
            this.btnLuuHV.UseVisualStyleBackColor = true;
            this.btnLuuHV.Click += new System.EventHandler(this.btnLuuHV_Click);
            // 
            // btnXoaHV
            // 
            this.btnXoaHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoaHV.Location = new System.Drawing.Point(378, 31);
            this.btnXoaHV.Name = "btnXoaHV";
            this.btnXoaHV.Size = new System.Drawing.Size(146, 45);
            this.btnXoaHV.TabIndex = 2;
            this.btnXoaHV.Text = "Xóa";
            this.btnXoaHV.UseVisualStyleBackColor = true;
            this.btnXoaHV.Click += new System.EventHandler(this.btnXoaHV_Click);
            // 
            // btnSuaHV
            // 
            this.btnSuaHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuaHV.Location = new System.Drawing.Point(198, 31);
            this.btnSuaHV.Name = "btnSuaHV";
            this.btnSuaHV.Size = new System.Drawing.Size(146, 45);
            this.btnSuaHV.TabIndex = 1;
            this.btnSuaHV.Text = "Chỉnh sửa";
            this.btnSuaHV.UseVisualStyleBackColor = true;
            this.btnSuaHV.Click += new System.EventHandler(this.btnSuaHV_Click);
            // 
            // btnThemHV
            // 
            this.btnThemHV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThemHV.Location = new System.Drawing.Point(18, 31);
            this.btnThemHV.Name = "btnThemHV";
            this.btnThemHV.Size = new System.Drawing.Size(146, 45);
            this.btnThemHV.TabIndex = 0;
            this.btnThemHV.Text = "Thêm ";
            this.btnThemHV.UseVisualStyleBackColor = true;
            this.btnThemHV.Click += new System.EventHandler(this.btnThemHV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(16, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 71);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin hội viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Name";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(173, 96);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(184, 30);
            this.txtAccountName.TabIndex = 4;
            this.txtAccountName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(173, 151);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(184, 30);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Group User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Money";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status Account ";
            // 
            // nbMoney
            // 
            this.nbMoney.Location = new System.Drawing.Point(574, 111);
            this.nbMoney.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nbMoney.Name = "nbMoney";
            this.nbMoney.Size = new System.Drawing.Size(173, 30);
            this.nbMoney.TabIndex = 12;
            this.nbMoney.ValueChanged += new System.EventHandler(this.nbMoney_ValueChanged);
            // 
            // cbGroupUser
            // 
            this.cbGroupUser.FormattingEnabled = true;
            this.cbGroupUser.Location = new System.Drawing.Point(174, 199);
            this.cbGroupUser.Name = "cbGroupUser";
            this.cbGroupUser.Size = new System.Drawing.Size(183, 30);
            this.cbGroupUser.TabIndex = 14;
            this.cbGroupUser.SelectedIndexChanged += new System.EventHandler(this.cbGroupUser_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Cho phép",
            "Hết thời gian"});
            this.cbStatus.Location = new System.Drawing.Point(574, 178);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(183, 30);
            this.cbStatus.TabIndex = 15;
            // 
            // MemberControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbGroupUser);
            this.Controls.Add(this.nbMoney);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(874, 590);
            this.Load += new System.EventHandler(this.MemberControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMember)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemHV;
        private System.Windows.Forms.Button btnLuuHV;
        private System.Windows.Forms.Button btnXoaHV;
        private System.Windows.Forms.Button btnSuaHV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nbMoney;
        private System.Windows.Forms.ComboBox cbGroupUser;
        private System.Windows.Forms.DataGridView dtgvMember;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}
