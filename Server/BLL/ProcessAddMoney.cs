using Microsoft.SqlServer.Server;
using Server.DAL;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.BLL
{
    public class ProcessAddMoney
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public bool insertAddMoney(AddMoneyTransaction x)
        {
            string query = "insert into AddMoneyTransaction values('" + x.ClientIP + "', '" + x.UserName + "', '" + x.MemberName + "','" + x.TransacDate + "', " + x.AddMoney + ",'"+x.Status+"')";
            if(DAL.runQuery(query)) return true;
            return false;
        }
        public bool addMoney(AddMoneyTransaction x)
        {
            string query = "insert into AddMoneyTransaction values('" + x.ClientIP + "', '" + x.UserName + "', '" + x.MemberName + "','" + x.TransacDate + "', " + x.AddMoney + ",'"+x.Status+"')";
            if(DAL.runQuery(query)) return true;
            return false;
        }

        public DataTable getRequest()
        {
            string query = "select * from AddMoneyTransaction where TransacStatus = 'WAITING' ORDER BY TransacDate DESC";
            return DAL.getDataTable(query);
        }

        public List<AddMoneyTransaction> getRequestList()
        {
            string query = "select * from AddMoneyTransaction where TransacStatus = 'WAITING' ORDER BY TransacDate DESC";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.AddMoneyTransaction> transacList = dt.AsEnumerable()
                .Select(row => new AddMoneyTransaction
                {
                    TransactionID = row.Field<int>("AddMoneyTransactionId"),
                    ClientIP = row.Field<string>("ClientIP"),
                    UserName = row.Field<string>("UserName"),
                    MemberName = row.Field<string>("MemberName"),
                    TransacDate = row.Field<DateTime>("TransacDate"),
                    AddMoney = row.Field<double>("AddMoney"),
                    Status = row.Field<string>("TransacStatus")
                }).ToList();
            return transacList;
        }
        public bool checkDone(AddMoneyTransaction x)
        {
            string query = "update AddMoneyTransaction set TransacStatus = 'SUCCESS' where AddMoneyTransactionId = '"+x.TransactionID+"'";
            if (DAL.runQuery(query)) return true;
            return false;
        }
        public bool deny(AddMoneyTransaction x)
        {
            string query = "update AddMoneyTransaction set TransacStatus = 'DENIED' where AddMoneyTransactionId = '" + x.TransactionID + "'";
            if (DAL.runQuery(query)) return true;
            return false;
        }
    }
}
