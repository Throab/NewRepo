using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class AddMoneyForm : Form
    {
        ClientForm clientForm;
        ClientManager clientManager;
        public AddMoneyForm(ClientForm mainFormClient, ClientManager clientManager)
        {
            InitializeComponent();
            this.clientForm = mainFormClient;
            this.clientManager = clientManager;
        }

        

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width - clientForm.Width, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClientForm.check2 = -1;
            if (btnAddMoney.Text == "WAITING...")
            {
                this.Hide();
                ClientForm.check = 1;
            }
            else
            {
                ClientForm.check = -1;
                this.Close();
            }
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            
            if(txtMoney.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền cần nạp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(btnAddMoney.Text == "Hoàn thành")
                {
                    ClientForm.check2 = -1;
                    this.Close();
                }
                else
                {
                    clientManager.addMoney(clientManager.userName, double.Parse(txtMoney.Text));
                    btnAddMoney.Text = "WAITING...";
                    btnAddMoney.ForeColor = Color.White;
                    btnAddMoney.Enabled = false;
                    ptbWaiting.Visible = true;
                    txtMoney.Enabled = false;
                }
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ClientManager.message == "Add money success")
            {
                ClientManager.message = "";
                ptbWaiting.Visible=false;
                ptbDone.Visible = true;
                btnAddMoney.Text = "Hoàn thành";
                btnAddMoney.ForeColor = Color.White;
                btnAddMoney.Enabled = true;
                btnClose.Visible = false;
            }
        }
    }
}
