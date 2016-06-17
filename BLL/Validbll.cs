using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Info;
using DLL;

namespace BLL
{
 public class Validbll
    {
        public DataSet GetValid()
        {
            Validdb oDb = new Validdb();
            return oDb.GetValid();

        }
        public bool SaveValid(ValidInfo oVld)
        {
            Validdb oDb = new Validdb();
            return oDb.Save(oVld);
        }
    }
}
