using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class ProcessBill
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        public int insertBill(Bill bill)
        {
            string query = "insert into Bill values('" + bill.UserID.ToString() + "','" + bill.MemberID.ToString() + "','" + bill.CreatedAt.ToString() + "','" + bill.TotalPrice.ToString() + "','WAITING');" +
                "select BillID from Bill where BillID = SCOPE_IDENTITY()";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            return dr.Field<int>("BillID");
        }
        public bool updateBill(Bill bill, string status)
        {
            string query = "update Bill set Status = '" + status + "' where BillID = '" + bill.BillID + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }
        public int getRecentBillID() {
            string query = "select BillID from Bill where BillID = SCOPE_IDENTITY()";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            return row.Field<int>("BillID");
        }
        public bool insertBillItem(int billId, List<Order> orderList)
        {
            foreach(Order order in orderList)
            {
                string query = "insert into Bill_Item values('" + billId.ToString() + "','" + order.Product.ProductID + "','" + order.Quantity.ToString() + "')";
                if (!DAL.runQuery(query)) return false;
            }
            return true;
        }
    }
}
