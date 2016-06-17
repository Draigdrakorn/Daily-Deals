using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
   public  class DealsInfo
    {
       private int _DealID;
       private String _Description;
       private String _TermsCondition;
       private double  _NormalPrice;
       private double _DealPrice;
       private DateTime _CreateDate;
       private DateTime _ModifiedDate;

    
    public int DealID
   {
    get { return _DealID; }
    set { _DealID= value;}
     }
     
      public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
      public String TermsCondition
        {
            get { return _TermsCondition; }
            set { _TermsCondition = value; }
        }

       public double NormalPrice
        {
            get { return _NormalPrice; }
            set { _NormalPrice = value; }
        }
       public double DealPrice
        {
            get { return _DealPrice; }
            set { _DealPrice = value; }
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
