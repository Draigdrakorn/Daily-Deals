using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Info;

namespace DLL
{
   public  class Locationdb
    {
         
        public DataSet GetLocation()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_Location]");

                return ds;
            }
            catch (Exception ex)
            {
                
                throw ex;

            }
        }

        public bool Save(LocationInfo objLoc)
        {
          try
            {
                SqlParameter[] @Params = new SqlParameter[2];
                @Params[0] = new SqlParameter("@Address", objLoc.Address);
                @Params[1] = new SqlParameter("@City", objLoc.City);
                
               
                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString,CommandType.StoredProcedure,  "[proc_Insert_Location]", @Params); 
              return true;
              
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
    
