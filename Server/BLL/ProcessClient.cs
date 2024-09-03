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

        public List<DTO.Client> getAllClient()
        {
            string query = "select * from Client";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.Client> clientList = dt.AsEnumerable()
                .Select(row => new Client
                {
                    ClientIP = row.Field<string>("ClientIP"),
                    ClientName = row.Field<string>("ClientName"),
                    GroupClientName = row.Field<string>("GroupClientName"),
                    StatusClient = row.Field<string>("StatusClient"),
                }).ToList();
            return clientList;
        }
        public string getClientName(string clientIp)
        {
            string query = "select ClientName from Client where ClientIP = '" + clientIp + "'";
            DataTable dt = DAL.getDataTable(query);
            DataRow row = dt.Rows[0];
            return row.Field<string>("ClientName");
        }
    }
}
