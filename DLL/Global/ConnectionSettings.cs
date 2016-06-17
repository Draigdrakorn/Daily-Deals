using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Configuration;

namespace DLL
{
    static class ConnectionSettings
    {
        private static string _cnString;
              
        public static string cnString
        {
            //Return _cnString
            get
            {
                return _cnString = ConfigurationManager.ConnectionStrings["Daily"].ToString();
                //return _cnString= ConfigurationManager.AppSettings["cn"]; }
            }
            set { }
        }

    }
}
