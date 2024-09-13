using Server.BLL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.GUI
{
    public partial class RequestMenuItem : UserControl
    {
        private Bill bill = new Bill();
        private InfoClient cli = new InfoClient();
        private ProcessMember processMember = new ProcessMember();
        private ProcessClient processClient = new ProcessClient();  
        public RequestMenuItem()
        {
            InitializeComponent();
        }
        public Bill Bill
        {
            get { return bill; }
            set 
            { 
                bill = value;
                lblMemberName.Text = processMember.getMemberName(bill.MemberID);
                lblTime.Text = bill.CreatedAt.ToString();
                lblTotalPrice.Text = currencyFormat(bill.TotalPrice);
            }
        }
        public InfoClient InfoClient
        {
            get { return cli;}
            set 
            { 
                cli = value;
                lblClientName.Text = processClient.getClientName(cli.clientIp);
            }
        }

        private string currencyFormat(double money) => string.Format(new CultureInfo("vi-VN"), "{0:C}", money);
    }
}
