using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Xml;

namespace DailyDeals
{
    public partial class items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds;
            Productbll pro = new Productbll();
            try
            {

                //load xml
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Server.MapPath("ProductUpdate.xml"));
                XmlNode rootNode = xmlDoc.SelectSingleNode("product");
                XmlNode valueNode = rootNode.FirstChild;
                int productNo = int.Parse(valueNode.InnerText);


                for (int i = 1; i < productNo; i++ )
                {

                
                    //load data from database
                
                    ds= pro.GetProduct(i);
                    DataTable dt = ds.Tables[0];
                    DataRow dr = dt.Rows[0];
                    string productName = Convert.ToString(dr["ProductName"]);
                    string specs = Convert.ToString(dr["Specification"]);
                    string expDate = Convert.ToString(dr["ExpiryDate"]);
                    int price = Convert.ToInt16(dr["DiscountedPrice"]);
                    string specifications = specs.Replace(";", "</br>");

                    itemcollection.InnerHtml += "<div class='col-xs-3 iteminfo'>" +
                        "<a href='/Details.aspx?productno=" + i + "'>" +
                            "<img class='img-circle' src='UploadedImages/product"+ i + ".jpg' width='100' height='100' /></a><h2>" + productName + "</h2>" +
                            "<p>" + specifications + "</br>" +
                            "Price: Rs." + price + "</br>" +
                            "Expires On: " + expDate + "</p>" +
                            
                            "<p><a class='btn btn-default' href='/Details.aspx?productno="+i+"' role='button'>View details &raquo;</a></p>" +
                    "</div>";
                 }
            }
            catch(Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}