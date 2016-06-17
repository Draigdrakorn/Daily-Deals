using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class SupplierInfo
    {
        private String _Name;
        private String _BusinessName;
        private String _Location;
        private DateTime _CreateDate;
        private DateTime _ModifiedDate;

        public String Name
        {
            get { return _Name; }
            set { _Name= value; }
        }
        public String BusinessName
        {
            get { return _BusinessName; }
            set { _BusinessName = value; }
        }
        public String Location
        {
            get { return _Location; }
            set { _Location= value; }
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

   