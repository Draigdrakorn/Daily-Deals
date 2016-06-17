using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace DailyDeals
{

    public partial class Default : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Productbll product = new Productbll();
            DataSet ds;

            //load xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("ProductUpdate.xml"));
            XmlNode rootNode = xmlDoc.SelectSingleNode("product");
            XmlNode valueNode = rootNode.FirstChild;
            int products = int.Parse(valueNode.InnerText);
            
            

            
            for (int i = 1; i < 4; i++)
            {
                

                //load data from database

                ds = product.GetProduct(i);
                DataTable dt = ds.Tables[0];
                DataRow dr = dt.Rows[0];
                
                string nameProduct = Convert.ToString(dr["ProductName"]);
                string specs = Convert.ToString(dr["Specification"]);
                string expDate = Convert.ToString(dr["ExpiryDate"]);
                int price = Convert.ToInt16(dr["DiscountedPrice"]);
                string specification = specs.Replace(";", "</br>");

                itemsDisplay.InnerHtml += "<div class='col-lg-4'>"+
                    "<img class='img-circle' src='UploadedImages/product"+ i+ ".jpg' alt='Generic placeholder image' width='140' height='140' />"+
                    "<h2>"+ nameProduct +"</h2>" +
                    "<p>"+specification+
                    "Price: Rs." + price + "</p>"+
                    "<p><a class='btn btn-default' href='/Details.aspx?productno=" + i + "' role='button'>View details &raquo;</a></p>" +
                    "</div>";
                }
            }

        }

        
        
    }
