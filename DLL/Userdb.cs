using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
   public class Userdb
    {

       public bool EmailCheck(string Email)
       {
           try{
               SqlParameter[] @Params = new SqlParameter[1];
               @Params[0] = new SqlParameter("@Email",Email);
               DataSet ds = new DataSet();
               ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_check_email]", @Params);
               DataTable dt = ds.Tables[0];
               if (dt.Rows.Count == 1)
               {
                   return false;
               }
               else
               {
                   return true;
               }
              }
           catch(Exception ex)
               {
                   throw ex;
               }
       }
       public bool ValidateUser(string Email, string Password)
       {
           try
           {
               SqlParameter[] @Params = new SqlParameter[2];
               @Params[0] = new SqlParameter("@Email", Email);
               @Params[1] = new SqlParameter("@Password",Password);
               DataSet ds = new DataSet();
               ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Validate_User]",@Params);
               DataTable dt = ds.Tables[0];
               if (dt.Rows.Count > 0)
                   return true;
               else
                   return false;
               
                             
           }
           catch (Exception ex)
           {
               
               throw ex;
           }
       }
        

       
        public DataSet GetUser()
        {
                try
                {
                    DataSet ds = new DataSet();
                    ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_User]");
                    return ds;
                }
                catch (Exception ex)
                {
                    
                    throw ex;

                }
             }

        

        public bool SaveUser(User objUsr)
        {
           try
            {

                SqlParameter[] @Params = new SqlParameter[6];
                @Params[0] = new SqlParameter("@LocationId", objUsr.LocationID);
                @Params[1] = new SqlParameter("@Email", objUsr.Email);
                @Params[2] = new SqlParameter("@Password", objUsr.Password);                
                @Params[3] = new SqlParameter("@FirstName", objUsr.FirstName);
                @Params[4] = new SqlParameter("@LastName", objUsr.LastName);
                @Params[5] = new SqlParameter("@Contact", objUsr.Contact);

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Insert_User]", @Params);
                return true;
}
            catch (Exception ex)
            {
               
                throw ex;
    }
}
    }

}