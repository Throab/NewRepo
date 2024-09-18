using Server.GUI;
using Server.socket_configure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class AdminPageForm : Form
    {
        private LoginForm loginForm;
        private AdminForm adminForm;
        Color blackGreenColor = Color.FromArgb(14, 60, 54);
        Color themeColor = Color.FromArgb(14, 104, 54);
        ServerManager serverManager;
        public AdminPageForm()
        {
            InitializeComponent();
        }
        public AdminPageForm(LoginForm loginForm, AdminForm adminForm, ServerManager serverManager)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.adminForm = adminForm;
            this.serverManager = serverManager;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void controlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                loginForm.Visible = true;
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm.Visible = true;
        }

        
        
        private void lblMember_Click(object sender, EventArgs e)
        {
            resetColor ();
            memberControl.BringToFront();
            pnlMember.BackColor = blackGreenColor;
            lblMember.BackColor = blackGreenColor;
            ptbMember.BackColor = blackGreenColor;
        }

        
        private void resetColor()
        {
            pnlMember.BackColor = Color.Transparent;
            pnlUserCtr.BackColor = Color.Transparent;
            lblMember.BackColor = Color.Transparent;
            lblUserCtr.BackColor = Color.Transparent;

            ptbUserCtr.BackColor = Color.Transparent;
            ptbMember.BackColor = Color.Transparent;

        }

        private void dashBoardControl1_Load(object sender, EventArgs e)
        {

        }

        private void dashBoardControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            resetColor();
            userAdminPageControl1.BringToFront();
            pnlUserCtr.BackColor = blackGreenColor;
            lblUserCtr.BackColor = blackGreenColor;
            ptbUserCtr.BackColor = blackGreenColor;
        }
    }
}
