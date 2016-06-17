using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using Info;
using System.Data;

namespace BLL
{
    public class Dealsbll
    {
        public DataSet GetDeals()
        {
            Dealsdb oDb = new Dealsdb();
            return oDb.GetDeals();

        }
        public bool SaveDeals(DealsInfo oDeal)
        {
            Dealsdb oDb = new Dealsdb();
            return oDb.Save(oDeal);
        }
    }
}
