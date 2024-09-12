using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Product
    {
        public int id;
        public string name;
        public int type;
        public string category;
        public double price;
        public string url;
        public int ProductID
        {
            get { return id; }
            set { id = value; }
        }
        public string ProductName
        {
            get { return name; }
            set { name = value; }
        }
        public int ProductType
        {
            get { return type; }
            set { type = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string ImageUrl
        {
            get { return url; }
            set { url = value; }
        }
    }
}
