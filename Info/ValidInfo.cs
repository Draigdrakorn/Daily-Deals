using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
  public class ValidInfo
    {
      private int _DealID;
      private DateTime _ValidTo;
      private DateTime _ValidFrom;
      private DateTime _CreateDate;
      private DateTime _ModifiedDate;

      public int DealID
      {
          get { return _DealID; }
          set { _DealID = value; }
    }
      public DateTime ValidTo
      {
          get { return _ValidTo; }
          set { _ValidTo = value; }
      }

      public DateTime ValidFrom
  {
          get { return _ValidFrom; }
          set { _ValidFrom = value; }
      }

    public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        public DateTime ModifiedDate
        {
            get { return _ModifiedDate; }
            set { _ModifiedDate = value; }
        }
       }
}