using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
   public class OrderInfo
    {
       private int _OrderID;
       private int _DealID;
       private String _UserEmail;
       private int _Quantity;
       private DateTime _OrderDate;
       private DateTime _CreateDate;
       private DateTime _ModifiedDate;

    public int OrderID
{
    get{return _OrderID;}
        set { _OrderID =value;}      
}

         public int DealID
{
        get{return _DealID;}
        set { _DealID =value;}      
}
         public String UserEmail
        {
           get { return _UserEmail; }
            set { _UserEmail =value;}
       }

       public int Quantity
{
        get{return _Quantity;}
        set { _Quantity =value;}      
}
       public DateTime OrderDate
       {
           get { return _OrderDate; }
           set { _OrderDate = value; }
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

