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
  public  class Categorybll
    {
      public DataSet GetCategory()
      {
          Categorydb oDb = new Categorydb();
          return oDb.GetAllCategory();
          
      }
      public bool SaveCategory(CategoryInfo oCat)
      {
          Categorydb oDb = new Categorydb();
          return oDb.InsertCategory(oCat);
      }
    }
}
