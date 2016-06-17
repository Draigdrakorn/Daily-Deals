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
    public class Userbll
    {

        public DataSet GetUser()
        {
            Userdb oDb = new Userdb();
            return oDb.GetUser();

        }
        public bool SaveUser(User oUsr)
        {
            try
            {
                Userdb oDb = new Userdb();
                return oDb.SaveUser(oUsr);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

          

        }
     
        public bool ValidateUser(string Email, string Password)
        {
            try
            {
                Userdb oDb = new Userdb();
                return oDb.ValidateUser(Email, Password);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
             
            
        }

        public bool EmailCheck(string Email)
        {
            try
            {
                Userdb oDb = new Userdb();
                return oDb.EmailCheck(Email);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
