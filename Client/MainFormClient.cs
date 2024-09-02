using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ClientForm : Form
    {
        ClientManager clientManager;
        const int USECLIENT = 101;
        const int MEMBERLOGIN = 102;
        const int PAYMENT = 103;
        int hour = 0;
        int min = 0;
        int sec = 0;
        double money = 0;
        TimeSpan total;
        TimeSpan use;
        TimeSpan remain;
        string userName = "";
        public ClientForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            clientManager = new ClientManager();
            money = clientManager.clientPrice;
            ClientManager.requestServer = -1;
            timerProgram.Enabled = true;
            timerProgram.Interval = 1000;
            timerProgram.Start();
        }
        public ClientForm(ClientManager x)
        {
            this.clientManager = x;
            InitializeComponent();

        }
        private void MainFormClient_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void grbUser_Enter(object sender, EventArgs e)
        {

        }

        private void timerProgram_Tick(object sender, EventArgs e)
        {
            try
            {


                if (ClientManager.requestServer != -1)
                {
                    if (ClientManager.requestServer == MEMBERLOGIN)
                    {
                        grbUser.Text = "Người dùng: " + clientManager.userName;
                        txtCurrentMoney.Text = clientManager.totalMoney.ToString();
                        userName = clientManager.userName;
                        ClientManager.requestServer = -2;
                        min = 0;
                        ResetTime();
                    }
                    TimeCount();
                    if (ClientManager.requestServer == -2)
                    {
                        use = TimeSpan.Parse(txtUsedTime.Text.ToString());
                        double remainingMoney = clientManager.totalMoney - money;
                        txtRemainingMoney.Text = Math.Round(remainingMoney, 0, MidpointRounding.AwayFromZero).ToString();
                        txtUseTimeFee.Text = "0";
                        clientManager.updateMoney(userName, Math.Round(remainingMoney, 0, MidpointRounding.AwayFromZero));
                    }

                    MoneyCount(txtUsedTime.Text.ToString());
                }
            }catch (Exception ex) {
                Application.Exit();
            }
        }
        private void ResetTime()
        {
            min = 0;
            sec = 0;
            hour = 0;
            money = 0;
        }
        
        private void MoneyCount(String useTime)
        {
            int time = ChangeUseTimeToMinutes(useTime);
            txtUseTimeFee.Text = Math.Round(money, 3, MidpointRounding.AwayFromZero).ToString();
            money += clientManager.clientPrice / 3600;
        }
        private int ChangeUseTimeToMinutes(String useTime)
        {
            int minutes = 0;
            string[] arrListStr = useTime.Split(':');
            if (int.Parse(arrListStr[1]) > 0)
            {
                minutes = minutes + int.Parse(arrListStr[1]);
            }

            if (int.Parse(arrListStr[0]) > 0)
            {
                minutes = minutes + int.Parse(arrListStr[0]) * 60;
            }

            return minutes;
        }
        private void TimeCount()
        {
            txtUsedTime.Text = hour.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
            sec++;
            if (sec > 59)
            {
                min++;
                sec = 00;
            }

            if (min > 59)
            {
                hour++;
                min = 00;
            }

            if (hour > 99)
            {
                timerProgram.Stop();
                timerProgram.Enabled = true;
            }

        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn đăng xuất.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                timerProgram.Start();
                txtCurrentMoney.Clear();
                txtRemainingMoney.Clear();
                txtServiceFee.Clear();
                txtUsedTime.Clear();
                txtUseTimeFee.Clear();
                grbUser.Text = "Username";
                ClientManager.requestServer = -1;
                clientManager.LogoutMember(userName);
            }
    }

        private void Info_Click(object sender, EventArgs e)
        {

        }
    }
}
