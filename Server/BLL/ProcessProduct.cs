using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
                    ProductType = row.Field<int>("Type"),
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


    }
}
