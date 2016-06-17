using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLL;
using Info;

namespace BLL
{
   public class Orderbll
    {
        public DataSet GetOrder()
        {
            Orderdb oDb = new Orderdb();
            return oDb.GetOrder();

        }
        public bool SaveOrder(OrderInfo oOrd)
        {
            Orderdb oDb = new Orderdb();
            return oDb.SaveOrder(oOrd);
        }
    }
}