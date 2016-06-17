using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Xml;

namespace DailyDeals
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        XmlDocument xmlDoc;
        XmlNode userloggedNode;
        XmlNode userEmailNode;
        XmlNode adminNode;
        protected void Page_Load(object sender, EventArgs e)
        {
            //xml Load
            xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("ProductUpdate.xml"));
            XmlNode rootNode = xmlDoc.SelectSingleNode("product");
            XmlNode userLogNode = rootNode.SelectSingleNode("userlog");
            userloggedNode = userLogNode.FirstChild;
            userEmailNode = userLogNode.SelectSingleNode("useremail");
            adminNode = userLogNode.SelectSingleNode("admin");
            bool loggedStatus = bool.Parse(userloggedNode.InnerText);
            string loggedEmail = userEmailNode.InnerText;
            bool adminStatus = bool.Parse(adminNode.InnerText);

            try
            {

                if (loggedStatus == true)
                {
                    welcomeDisplay.InnerHtml = "Welcome, " + loggedEmail;
                    logout.Style.Add("Display", "block");
                    loginnav.Style.Add("Display", "none");
                    if(adminStatus == true)
                    {
                        welcomeDisplay.InnerHtml = "Welcome, admin";
                        logout.Style.Add("Display", "block");
                        loginnav.Style.Add("Display", "none");
                        addproductnav.Style.Add("Display", "block");
                    }
                }

                if(loggedStatus == false)
                {
                    welcomeDisplay.InnerHtml = "";
                    logout.Style.Add("Display", "none");
                    loginnav.Style.Add("Display", "block");
                    addproductnav.Style.Add("Display", "none");
                }
            }

            catch(Exception ex)
            {
                throw ex;
            }

        }

        protected void signupbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/SignUp.aspx");
            
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            Userbll user = new Userbll();

            bool UserValidate;
            string Email = loginEmail.Text;
            string Password = loginPassword.Text;
            try
            {
                UserValidate = user.ValidateUser(Email, Password);
                if (UserValidate == true)
                {
                    userloggedNode.InnerText = "true";
                    userEmailNode.InnerText = Email;
                    
                    if(Email == "admin@admin.com")
                    {
                        adminNode.InnerText = "true";
                    }
                    //save xml
                    xmlDoc.Save(Server.MapPath("ProductUpdate.xml"));
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    Response.Write("<script>alert('Wrong Email and/or Password')</script>");
                }


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void logoutid_ServerClick(object sender, EventArgs e)
        {
            userloggedNode.InnerText = "false";
            userEmailNode.InnerText = "";
            adminNode.InnerText = "false";
            //save xml
            xmlDoc.Save(Server.MapPath("ProductUpdate.xml"));
            Response.Redirect(Request.RawUrl);
        }
    }
}