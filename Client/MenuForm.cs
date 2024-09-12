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
    public partial class MenuForm : Form
    {
        private List<Product> products;
        public MenuForm()
        {
            InitializeComponent();
        }
        public void loadDataProduct()
        {
            Product p = new Product{
                name = "Mì xào khô",
                price = 20000,
                url = "https://res.cloudinary.com/dale7wvyi/image/upload/v1726140648/xexjfbwzd7bain4kcsp9.jpg"
            };
            ProductItem item = new ProductItem();
            item.Product = p;
            pnlProductContainer.Controls.Add(item);
            item = new ProductItem();
            item.Product = p;
            pnlProductContainer.Controls.Add(item);
            item = new ProductItem();
            item.Product = p;
            pnlProductContainer.Controls.Add(item);
            item = new ProductItem();
            item.Product = p;
            pnlProductContainer.Controls.Add(item);
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            loadDataProduct();
        }
    }
}
