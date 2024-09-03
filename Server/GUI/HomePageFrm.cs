using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.GUI
{
    public partial class HomePageFrm : Form
    {
        LoginForm loginForm = null;
        AdminForm adminForm = null;
        public HomePageFrm()
        {
            InitializeComponent();
        }
        public HomePageFrm(LoginForm loginForm,AdminForm adminForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.adminForm = adminForm;
        }
        public HomePageFrm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void HomePageFrm_Load(object sender, EventArgs e)
        {
            if(adminForm == null)
            {
                back.Visible = false;
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            adminForm.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                loginForm.Show();
            }
        }

        private void clientManage_Click(object sender, EventArgs e)
        {
            clientHomePageControl1.BringToFront();
        }

        private void MemberManage_Click(object sender, EventArgs e)
        {
            memberHomePageControl1.BringToFront();
        }

        private void Request_Click(object sender, EventArgs e)
        {
            requestControl1.BringToFront();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            chatControl1.BringToFront();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát.","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { 
                Application.Exit();
            }
        }
    }
}
