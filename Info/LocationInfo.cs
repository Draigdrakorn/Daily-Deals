using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class LocationInfo
    {
        private int _LocationID;
        private String _Address;
        private String _City;
        private String _UserEmail;
        private DateTime _CreateDate;
        private DateTime _ModifiedDate;

        public int LocationID
        {
            get { return _LocationID; }
            set { _LocationID = value; }
        }
        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public String City
        {
            get { return _City; }
            set { _City = value; }
        }
        public String UserEmail
        {
            get { return _UserEmail; }
            set { _UserEmail = value; }
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
