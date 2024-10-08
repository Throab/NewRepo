﻿using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.BLL
{
    public class ProcessProduct
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        public List<DTO.Product> getAllProducts()
        {
            string query = "select * from Product where InventoryNumber > 0";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Product> productList = dt.AsEnumerable()
                .Select(row => new Product
                {
                    ProductID = row.Field<int>("ProductID"),
                    ProductName = row.Field<string>("ProductName"),
                    Category = row.Field<string>("CategoryName"),
                    Price = row.Field<double>("Price"),
                    InventoryNumber = row.Field<int>("InventoryNumber"),
                    ImageUrl = row.Field<string>("ImageUrl")
                }).ToList();
            return productList;
        }

        public List<string> getAllCategory()
        {
            string query = "select * from Category";
            DataTable dt = DAL.getDataTable(query);
            List<string> list = new List<string>();
            foreach(DataRow dataRow in dt.Rows)
            {
                string s = dataRow.Field<string>("CategoryName");
                list.Add(s);
            }
            return list;
        }
        public bool updateProductInventory(int productId, int quantity)
        {
            int m = getProduct(productId).InventoryNumber - quantity;
            string query = "update Product set InventoryNumber = '" + m.ToString() + "' where ProductID = '" + productId.ToString() + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }
        public Product getProduct(int productID)
        {
            string query = "select * from Product where ProductID = '" + productID + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            Product product = new Product
            {
                ProductID = row.Field<int>("ProductID"),
                ProductName = row.Field<string>("ProductName"),
                Category = row.Field<string>("CategoryName"),
                Price = row.Field<double>("Price"),
                InventoryNumber = row.Field<int>("InventoryNumber"),
                ImageUrl = row.Field<string>("ImageUrl")
            };
            return product;
        }
        public double getPrice(int productID)
        {
            string query = "select Price from Product where ProductID = '"+productID+"'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            return dr.Field<double>("Price");
        }
        public string getProductName(int productID)
        {
            string query = "select ProductName from Product where ProductID = '" + productID + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            return dr.Field<string>("ProductName");
        }
    }
}
