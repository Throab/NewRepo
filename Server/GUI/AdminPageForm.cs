using Server.GUI;
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
        public AdminPageForm()
        {
            InitializeComponent();
        }
        public AdminPageForm(LoginForm loginForm, AdminForm adminForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.adminForm = adminForm;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("a", "aa");
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

        private void lblMainPage_Click(object sender, EventArgs e)
        {
            dashBoardControl.BringToFront();
        }

        private void lblClientPage_Click(object sender, EventArgs e)
        {
            clientControl.BringToFront();
        }

        private void lblMember_Click(object sender, EventArgs e)
        {
            memberControl.BringToFront();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            menuControl.BringToFront();
        }
    }
}
