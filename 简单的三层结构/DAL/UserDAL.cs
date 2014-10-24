using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;
using Entity;


namespace DAL
{
    public class UserDAL
    {
        static string connectString = "data source=slkm3;uid=system;pwd=sanliankm3";
        OracleConnection conn = new OracleConnection(connectString);

        public User Dlogin(User user)
        {
                string sqlString = "select * from UserInfo where UserName='" + user.UserName + "'";
                User euser = new User();
                conn.Open();
                OracleCommand cmd = new OracleCommand(sqlString, conn);
                OracleDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                euser.UserName = reader[0].ToString();
                euser.Pwd = reader[1].ToString();
                return euser;
            }
        }
    
}
