using Project_PRN211_Group3.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRN211_Group3.DAL
{
   public class UserDAO :DAO
    {
        static UserDAO instance;
        UserDAO() { }
        static UserDAO() => instance = new UserDAO();
        public static UserDAO GetInstance() => instance;

        public List<User> GetList()
        {
            DataTable dt;
            dt = GetDataTable("SELECT * FROM [User]");
            List<User> list = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    User user = new User
                    {
                        CusId = (int)row["CusID"],
                        UserName = row["UserName"].ToString(),
                     Password = row["Password"].ToString()
                    };
                    list.Add(user);
                }
                catch { }
            }
            return list;
        }
    }
}
