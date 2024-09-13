using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Client
{
    public partial class MenuForm : Form
    {
        private List<Product> products;
        private List<string> listCategory;
        public static List<Cart> listCart = new List<Cart>();
        public static List<int> listId = new List<int>();
        public static int checkClick = -1;
        private ClientForm clientForm;
        private ClientManager clientManager;
        public MenuForm(ClientForm clientForm, ClientManager clientManager)
        {
            InitializeComponent();
            this.clientForm = clientForm;
            this.clientManager = clientManager;
            products = clientManager.productList;
            listCategory = clientManager.categoryList;
            listCategory.Insert(0, "Tất cả");
            
        }
        public void loadAllDataProduct()
        {
            pnlProductContainer.Controls.Clear();
            foreach (Product product in products)
            {
                ProductItem item = new ProductItem();
                item.Product = product;
                pnlProductContainer.Controls.Add(item);
            }
        }
        public void loadDataProduct(string category)
        {
            pnlProductContainer.Controls.Clear();
            foreach (Product product in products)
            {
                if(product.Category == category)
                {
                    ProductItem item = new ProductItem();
                    item.Product = product;
                    pnlProductContainer.Controls.Add(item);
                }               
            }
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = clientManager.categoryList;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategory.SelectedIndex == 0) {
                loadAllDataProduct();
            }
            else
            {
                loadDataProduct(cbCategory.SelectedValue.ToString());
            }
        }
        private void loadCart()
        {
            pnlCart.Controls.Clear();
            foreach(Cart cart in listCart)
            {
                CartItem item = new CartItem();
                item.Cart = cart;
                pnlCart.Controls.Add(item);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkClick == 1)
            {
                checkClick = -1;
                loadCart();
            }
        }

        private void pnlCart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            foreach(CartItem item in pnlCart.Controls)
            {
                foreach(Cart cart in listCart)
                {
                    if(cart.Product.ProductID == item.Cart.Product.ProductID)
                    {
                        cart.Quantity = item.getQuantity();
                    }
                }
            }
            clientManager.sendOrder(orderToString(listCart));
            BillForm billForm = new BillForm();
            billForm.Show();
        }
        private string orderToString(List<Cart> carts)
        {
            string str = "";
            foreach(Cart cart in carts)
            {
                str += "|" + cart.Product.ProductID.ToString() + "|" + cart.Quantity.ToString();
            }
            return str;
        }
    }
}
