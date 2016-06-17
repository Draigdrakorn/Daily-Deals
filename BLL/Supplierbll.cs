using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data ;
using Info ;
using DLL;


namespace BLL
{
    public class Supplierbll
    {
        public DataSet GetSupplier()
        {
            Supplierdb oDb = new Supplierdb();
            return oDb.GetSupplier();

        }
        public bool SaveSupplier(SupplierInfo oSup)
        {
            Supplierdb oDb = new Supplierdb();
            return oDb.SaveSupplier(oSup);
        }
    }
}
