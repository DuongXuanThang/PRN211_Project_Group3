using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN211_Group3.DAL
{
  public  class DAO
    {
        public DataTable GetDataTable(string sql)
        {
            try
            {
                SqlConnection conn = new SqlConnection(getStringConnection());

                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        public void Update(SqlCommand cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(getStringConnection());
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        string getStringConnection()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString("Group3");
        }
    }
}

