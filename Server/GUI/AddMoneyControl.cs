using Server.BLL;
using Server.DTO;
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
    public partial class AddMoneyControl : UserControl
    {
        private ProcessAddMoney ProcessAddMoney = new ProcessAddMoney();
        private List<AddMoneyTransaction> transactionList;
        public AddMoneyControl()
        {
            InitializeComponent();
        }

        private void AddMoneyControl_Load(object sender, EventArgs e)
        {
            transactionList = ProcessAddMoney.getRequestList();
            foreach (AddMoneyTransaction transaction in transactionList)
            {
                AddMoneyRequestItem item = new AddMoneyRequestItem();
                item.AddMoneyTransaction = transaction;
                pnlRequestContainer.Controls.Add(item);
            }
        }
    }
}
