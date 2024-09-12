using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Client
{
    public partial class ProductItem : UserControl
    {
        Product product = new Product();
        public ProductItem()
        {
            InitializeComponent();
        }
        public Product Product { 
            get { return product; } 
            set 
            { 
                product = value;
                lblProductName.Text = product.ProductName;
                lblProductPrice.Text = product.Price.ToString();
                WebClient webClient = new WebClient();
                Stream stream = webClient.OpenRead(product.ImageUrl);
                Bitmap bitmap = new Bitmap(stream);
                ptbProductImg.SizeMode = PictureBoxSizeMode.Zoom;
                ptbProductImg.Image = bitmap;
            }
        }
    }
}
