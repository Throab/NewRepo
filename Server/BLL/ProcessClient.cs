using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.BLL
{
    public class ProcessClient
    {
        DataAccessLayer DAL =  new DataAccessLayer();
        public void changeStateClient(InfoClient cli)
        {
            string query = "update Client set StatusClient = '" + cli.stateClient + "' where ClientIP = '" + cli.clientIp + "'";
            if(DAL.runQuery(query))
            {}
        }
        public string getGroupName(InfoClient cli)
        {
            string groupName;
            string query = "select GroupClientName from Client where ClientIP = '"+cli.clientIp+"'";
            DataTable dt = DAL.getDataTable(query);
            DataRow dr = dt.Rows[0];
            groupName = dr.Field<string>("GroupClientName");
            return groupName;
        }

        
    }
}
