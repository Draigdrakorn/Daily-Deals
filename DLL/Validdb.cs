using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Info;
using System.Data.SqlClient;

namespace DLL
{
   public class Validdb
    {
        
        public DataSet GetValid()
        {


            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_Valid]");
                return ds;
            }
            catch (Exception ex)
            {
               

                throw ex;

            }
        }

        public bool Save(ValidInfo objVld)
        {
            
            try
            {

                SqlParameter[] @Params = new SqlParameter[3];
                @Params[0] = new SqlParameter("@DealId", objVld.DealID);
                @Params[1] = new SqlParameter("@ValidTo", objVld.ValidTo);
                @Params[2] = new SqlParameter("@ValidFrom", objVld.ValidFrom);

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Insert_Valid]", @Params);
                return true;
                  }
            catch (Exception ex)
            {
             
                throw ex;
            }
               }
        }
    }