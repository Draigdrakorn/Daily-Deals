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
    public class Dealsdb
    {
        
        public DataSet GetDeals()
        {
           

            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_Deals]");
                return ds;
            }
            catch (Exception ex)
            {
               
                throw ex;

            }
        }

        public bool Save(DealsInfo objDel)
        {
           
            try
            {

                SqlParameter[] @Params = new SqlParameter[4];
                @Params[0] = new SqlParameter("@Description", objDel.Description);
                @Params[1] = new SqlParameter("@TermsCondition", objDel.TermsCondition);
                @Params[2] = new SqlParameter("@NormalPrice", objDel.NormalPrice);
                @Params[3] = new SqlParameter("@DealPrice", objDel.DealPrice);
               

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString,CommandType.StoredProcedure, "[proc_Insert_Deals]", @Params);
                return true;

               }
            catch (Exception ex)
            {
               
                throw ex;
            }

        }
    }
}
    
