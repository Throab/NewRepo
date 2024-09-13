using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class BillForm : Form
    {
        List<Cart> listCart;
        public BillForm()
        {
            InitializeComponent();
            
        }
        
        private void BillForm_Load(object sender, EventArgs e)
        {
            Label lbl1 = new Label() { Text = "STT", TextAlign = ContentAlignment.MiddleCenter};
            Label lbl2 = new Label() { Text = "Tên món", TextAlign = ContentAlignment.MiddleCenter};
            Label lbl3 = new Label() { Text = "Số lượng", TextAlign = ContentAlignment.MiddleCenter, AutoSize = true};
            Label lbl4 = new Label() { Text = "Thành tiền", TextAlign = ContentAlignment.MiddleCenter, AutoSize = true };
            tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl2, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl3, 2, 0);
            tableLayoutPanel1.Controls.Add(lbl4, 3, 0);

            listCart = MenuForm.listCart;
            tableLayoutPanel1.RowCount = listCart.Count;
            MessageBox.Show(tableLayoutPanel1.RowCount.ToString());
            for(int i = 1; i <= listCart.Count; i++)
            {
                Label stt = new Label();
                stt.Text = (i).ToString();
                stt.TextAlign = ContentAlignment.MiddleCenter;
                Label name = new Label();
                name.AutoSize  = true;
                name.Text = listCart[i - 1].Product.ProductName;
                Label quantity = new Label();
                quantity.Text = listCart[i - 1].Quantity.ToString();
                quantity.TextAlign = ContentAlignment.MiddleCenter;
                Label money = new Label();
                double m = listCart[i - 1].Quantity * listCart[i - 1].Product.Price;
                money.Text = m.ToString();
                tableLayoutPanel1.Controls.Add(stt, 0, i);
                tableLayoutPanel1.Controls.Add(name, 1, i);
                tableLayoutPanel1.Controls.Add(quantity, 2, i);
                tableLayoutPanel1.Controls.Add(money, 3, i);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
