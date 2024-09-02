using Server.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    
    public class ProcessGroupClient
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public double getClientPrice(string groupName)
        {
            double price = 0;
            string query = "select Price from GroupClient where GroupName = '"+groupName+"'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            price = dr.Field<double>("Price");
            return price;
        }

    }
}
