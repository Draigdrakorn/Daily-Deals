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
    public class Locationbll
    {
        public DataSet GetLocation()
        {
            Locationdb oDb = new Locationdb();
            return oDb.GetLocation();

        }
        public bool SaveLocation(LocationInfo oLoc)
        {
            Locationdb oDb = new Locationdb();
            return oDb.Save(oLoc);
        }
    }
}
