using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info;
using DLL;
using System.Data;

namespace BLL
{
    public class Productbll
    {
        public DataSet GetProduct(int ProductID)
        {
            Productdb oDb = new Productdb();
            return oDb.GetProduct(ProductID);

        }
        public bool SaveProduct(ProductInfo oPdt)
        {
            Productdb oDb = new Productdb();
            return oDb.SaveProduct(oPdt);
        }
    }
}
