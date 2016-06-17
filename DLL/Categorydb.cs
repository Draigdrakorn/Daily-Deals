using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Info;
using System.Data;

namespace DLL
{
   public class Categorydb
    {
       

        public bool InsertCategory(CategoryInfo objCat)
        {
            try
            {
                SqlParameter[] @Params = new SqlParameter[1];
                @Params[0] = new SqlParameter("@Description", objCat.Description);

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Insert_Category]", @Params);  
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }

        public DataSet GetAllCategory()
       {
           try
           {
               DataSet ds= new DataSet();
               ds=SqlHelper.ExecuteDataset(ConnectionSettings.cnString,CommandType.StoredProcedure,"[proc_Select_Category]");
               return ds;
           }
           catch(Exception ex)
           {
               throw ex;
            }
        }

     
       
       
    }
          
}