using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.BLL
{
    public class ProcessMember
    {
        private DataAccessLayer DAL = new DataAccessLayer();
        public bool checkLoginMember(string username, string password)
        {
            string query = "select * from Member where AccountName = '" + username + "' and Password = '" + password + "'";
            DataTable dt = DAL.getDataTable(query);
            return dt.Rows.Count > 0;
        }
        public double getTotalMoney(string username)
        {
            double totalMoney = 0;
            string query = "select CurrentMoney from Member where AccountName = '" + username + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            totalMoney = row.Field<double>("CurrentMoney");
            return totalMoney;
        }
        public void updateCurrentMoney(string username, double money)
        {
            string query = "update Member set CurrentMoney = '" + money + "' where AccountName = '" + username + "'";
            if (DAL.runQuery(query))
            {
            }
        }


        public bool updateNewPass(string userName, string password)
        {
            string query = "update Member set Password = '" + password + "' where AccountName = '" + userName + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }

        public bool checkValidMember(string username) {
            string query = "select * from Member where AccountName = '" + username + "' and  CurrentMoney > 0";
            DataTable dt = DAL.getDataTable(query);
            return dt.Rows.Count > 0;
        }
    }
}
