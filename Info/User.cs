using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class User
    {
        private int _LocationId;
        private String _Email;
        private String _Password;
        private int _Contact;
        private String _FirstName;
        private String _LastName;
        private DateTime _CreateDate;
        private DateTime _ModifiedDate;

        public int LocationID { get; set; }
        public String Email
        {
            get { return _Email;}
            set { _Email =value;}
}
        public String Password
        {
            get { return _Password;}
            set { _Password =value;}
        }

        public int Contact
        {
            get { return _Contact;}
            set { _Contact =value;}
}
         public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName= value; }
        } 
        public String LastName
        {
            get { return _LastName; }
            set { _LastName= value; }
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

