using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

 namespace  DLL
{
    public class Connection
    {
        SqlConnection connection;
        SqlCommand command;

        public Connection()
        {
            // Initializaton of Connection class as soon as connection class opens
            // new connection to database is made
            connection = new SqlConnection();

            string strConnStr = null;
            strConnStr = ConfigurationManager.ConnectionStrings["Daily"].ToString();
            connection.ConnectionString = strConnStr;

            
            connection.Open();
        }

        public bool ExecuteQuery(string strSQL)
        {
            int i = 0;
            try
            {
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = strSQL;
                i = command.ExecuteNonQuery();
                if (i == 0)
                {
                    connection.Close();
                    return false;
                }
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public DataSet GetDataSet(string strSQL)
        {
            DataSet ds;
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter(strSQL, connection);
                ds = new DataSet();
                adp.Fill(ds);
               
                connection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;

            }
        }

    }
}



