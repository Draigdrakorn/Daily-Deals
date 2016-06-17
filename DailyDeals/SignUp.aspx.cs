using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;
using Info;
namespace DailyDeals
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //initialization
                fNameErr.InnerHtml = "";
                lNameErr.InnerHtml = "";
                PasswordErr.InnerHtml = "";
                rePasswordErr.InnerHtml = "";
                cNoErr.InnerHtml = "";
                EmailErr.InnerHtml = "";
                

                //database part
                DataSet ds = new DataSet();
                Locationbll oLoc = new Locationbll();
                ds = oLoc.GetLocation();

                DataTable dt = ds.Tables[0];
                drlocation.DataSource = dt;
                drlocation.DataTextField = "City";
                drlocation.DataValueField = "LocationID";
                drlocation.DataBind();
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message.ToString());
            }
           
        }

        protected void regButton_Click(object sender, EventArgs e)
        {
            try
            {

                //Validate User Code
                if (txtfName.Text == "")
                {
                    fNameErr.InnerHtml = "<i style='color:red;'>Please Enter your First Name</i>";
                    txtfName.Focus();

                }
                else if(txtlName.Text == "")
                {
                    lNameErr.InnerHtml = "<i style='color:red;'>Please Enter your Last Name</i>";
                    txtlName.Focus();

                }
                else if (txtEmail.Text == "")
                {
                    EmailErr.InnerHtml = "<i style='color:red;'>Please Enter your Email</i>";
                    txtEmail.Focus();
                }
                else if (txtPassword.Text == "")
                {
                    PasswordErr.InnerHtml = "<i style='color:red;'>Please Enter a Password</i>";
                    txtPassword.Focus();
                }
                else if (txtRePassword.Text == "")
                {
                    rePasswordErr.InnerHtml = "<i style='color:red;'>Please Re-Enter your Password</i>";
                    txtRePassword.Focus();
                }
                else if (txtPassword.Text != txtRePassword.Text)
                {
                    Response.Write("<script>alert('Your Passwords do not match');</script>");
                    txtPassword.Focus();
                }

                else if (txtContNo.Text == "")
                {
                    cNoErr.InnerHtml = "<i style='color:red;'>Please Enter your Contact Number</i>";
                    txtContNo.Focus();

                }
                else
                {
                    
                    //Save User Code
                    Userbll oUBll = new Userbll();
                    User oUser = new User();
                    //initialization for checking duplicate emails 
                    string Email = txtEmail.Text;
                    bool CheckEmail;
                    CheckEmail = oUBll.EmailCheck(Email);

                    //If the email already exist then display message to enter different email
                    if(CheckEmail == false)
                    {
                        Response.Write("<script>alert('The Email address already exists!');</script>");
                        txtEmail.Focus();
                    }
                    else
                    {
                    oUser.FirstName = txtfName.Text;
                    oUser.LastName = txtlName.Text;
                    oUser.Email = txtEmail.Text;
                    oUser.Password = txtPassword.Text;
                    oUser.Contact = int.Parse(txtContNo.Text);
                    oUser.LocationID = Convert.ToInt32(drlocation.SelectedValue);
                    bool confirm = oUBll.SaveUser(oUser);
                    Response.Write("User Registered Successfully");
                    }
                }
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message.ToString());
            }
        }
    }
}