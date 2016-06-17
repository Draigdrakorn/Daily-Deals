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
   public class Productdb
    {
        
        public DataSet GetProduct(int ProductID)
        {
            try
            {
                SqlParameter[] @Params = new SqlParameter[1];
                @Params[0] = new SqlParameter("@ProductID", ProductID);
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Select_Product]",@Params);
                return ds;
            }
            catch (Exception ex)
            {
                
                throw ex;

            }
        }

        public bool SaveProduct(ProductInfo objPdt)
        {
           
            try
            {
                SqlParameter[] @Params = new SqlParameter[8];
                @Params[0] = new SqlParameter("@CategoryID", objPdt.CategoryID);
                @Params[1] = new SqlParameter("@DealID", objPdt.DealID);
                @Params[2] = new SqlParameter("@SupplierID", objPdt.SupplierID);
                @Params[3] = new SqlParameter("@ProductName", objPdt.ProductName);
                @Params[4] = new SqlParameter("@Specification", objPdt.Specification);
                @Params[5] = new SqlParameter("@ExpiryDate", objPdt.ExpiryDate);
                @Params[6] = new SqlParameter("@RegularPrice", objPdt.RegularPrice);
                @Params[7] = new SqlParameter("@DiscountedPrice", objPdt.DiscountedPrice);
                

                SqlHelper.ExecuteNonQuery(ConnectionSettings.cnString, CommandType.StoredProcedure, "[proc_Insert_Product]", @Params);
                return true;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
    