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

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                clientManager.addMoney(clientManager.userName, double.Parse(txtMoney.Text));
                btnAddMoney.Text = "<<<<<WAITING>>>>>";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ClientManager.message == "Add money success")
            {
                ClientManager.message = "";
                MessageBox.Show("Add success");
                this.Close();
            }
        }
    }
}
