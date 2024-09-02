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
    internal class ProcessUser
    {
        DataAccessLayer DAL = new DataAccessLayer();
        public bool checkLoginServer(string username, string password)
        {
            string query = "select * from Users where Username = '" + username + "' and Password = '" + password + "'";
            DataTable dt = DAL.getDataTable(query);
            if (dt.Rows.Count > 0) return true;
            return false;
        }
        public List<DTO.User> getAllUser()
        {
            string query = "select * from Users";
            DataTable dt = DAL.getDataTable(query);
            List<DTO.User> usersList = dt.AsEnumerable()
                .Select(row => new User
                {
                    UserName = row.Field<string>("UserName"),
                    FullName = row.Field<string>("FullName"),
                    GroupUser = row.Field<string>("GroupUser"),
                    Password = row.Field<string>("Password"),
                    PhoneNumber = row.Field<string>("PhoneNumber"),
                    Email = row.Field<string>("Email")

                }).ToList();
            return usersList;
        }
        public bool checkIsAdmin(string username)
        {
            string query = "select GroupUser from Users where UserName = '" + username + "'";
            DataTable dt = DAL.getDataTable(query);
            if(dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string groupUser = row.Field<string>("GroupUser");
                if (groupUser == "Manager") return true;
            }
            return false;
        }
    }
}
