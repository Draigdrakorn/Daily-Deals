using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info;
using System.Data.SqlClient;
using System.Data;

namespace DLL
{
   public class Supplierdb
    {
        
        public DataSet GetSupplier()
        {

            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_Supplier]");
                return ds;

            }
            catch (Exception ex)
            {
               
                throw ex;

            }
        }

        public bool SaveSupplier(SupplierInfo objSup)
        {
         
            try
            {

                SqlParameter[] @Params = new SqlParameter[3];
                @Params[0] = new SqlParameter("@Name",  objSup.Name);
                @Params[1] = new SqlParameter("@BusinessName", objSup.BusinessName);
                @Params[2] = new SqlParameter("@Location",  objSup.Location);

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Insert_Supplier]", @Params);
                return true;
            }
            catch (Exception ex)
            {
           
                throw ex;
            }

        }
    }
}
  
