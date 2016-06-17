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
   public class Orderdb
    {
       
        public DataSet GetOrder()
        {
         try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_Order]");
                return ds;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;

            }
        }

        public bool SaveOrder(OrderInfo objOrd)
        {
          try
          {
                SqlParameter[] @Params = new SqlParameter[4];
                @Params[0] = new SqlParameter("@DealID", objOrd.DealID);
                @Params[1] = new SqlParameter("@UserEmail", objOrd.UserEmail);
                @Params[2] = new SqlParameter("@Quantity", objOrd.Quantity);
                @Params[3] = new SqlParameter("@OrderDate", objOrd.OrderDate);

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString, "[proc_Insert_Order]", @Params);
                  return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

        }
    }
}
   
