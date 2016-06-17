using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class ProductInfo
    {
        private int _ProductID;
        private int _CategoryID;
        private int _DealID;
        private int _SupplierID;
        private String _ProductName;
        private string _Specification;
        private DateTime _CreateDate;
        private string _ExpiryDate;
        private int _RegularPrice;
        private int _DiscountedPrice;

        public int ProductID
        {
            get{return _ProductID;}
            set { _ProductID =value;}      
        }
        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }
        public int DealID
        {
            get{return _DealID;}
            set { _DealID =value;}   
        }
        public int SupplierID
        {
            get { return _SupplierID; }
            set { _SupplierID = value; }
        }
        public String ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }
        public string Specification
        {
            get { return _Specification; }
            set { _Specification = value; }
        }
  
        public DateTime CreateDate
        {
            get { return _CreateDate; }
            set { _CreateDate = value; }
        }

        public string ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

        public int RegularPrice
        {
            get { return _RegularPrice; }
            set { _RegularPrice = value;}

        }
        
        public int DiscountedPrice
        {
            get { return _DiscountedPrice; }
            set { _DiscountedPrice = value; }
        }

    }
}
