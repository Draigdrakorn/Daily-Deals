using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class CategoryInfo
    {
        private int _CategoryID;
        private String _Description;
        private DateTime _CreateDate;
        private DateTime _ModifiedDate;

        public int CategoryID
        {
            get { return _CategoryID; }
            set { _CategoryID = value; }
        }


        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
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