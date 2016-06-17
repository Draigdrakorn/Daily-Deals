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
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Productbll product= new Productbll();
            DataSet ds;
            int productNo;

            //extract querystring
            if(!string.IsNullOrEmpty(Request.QueryString["productno"]))
            {
                productNo = int.Parse(Request.QueryString["productno"]);
            }
            else
            {
                productNo = 0;
            }

            //load data
            ds = product.GetProduct(productNo);
            DataTable dt = ds.Tables[0];
            DataRow dr = dt.Rows[0];
            string nameProduct = Convert.ToString(dr["ProductName"]);
            string specs = Convert.ToString(dr["Specification"]);
            string expDate = Convert.ToString(dr["ExpiryDate"]);
            DateTime addedDate = (Convert.ToDateTime(dr["CreateDate"])).Date;
            int dPrice = Convert.ToInt16(dr["DiscountedPrice"]);
            int rPrice = Convert.ToInt16(dr["RegularPrice"]);
            string spec1 = specs.Replace(":", ":</p></div><div class='col-xs-4'><p>");
            string specification = spec1.Replace(";", "</p></div><div class='col-xs-6'><p>");
            int cat = Convert.ToInt16(dr["CategoryID"]);

            image.Src = "UploadedImages/product" + productNo +".jpg";
            productName.InnerText = nameProduct;
            discPrice.InnerText = dPrice.ToString();
            orgPrice.InnerText = rPrice.ToString();
            float discount = ((((float)rPrice - (float)dPrice) / (float)rPrice) * 100);
            discPerc.InnerText = discount.ToString() + "%";
            specifications.InnerHtml="<div class='col-xs-6'><p>"+ specification +"</div>";
            addDate.InnerText = addedDate.ToString("d");
            expireDate.InnerText = expDate;

            //load xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Server.MapPath("ProductUpdate.xml"));
            XmlNode rootNode = xmlDoc.SelectSingleNode("product");
            XmlNode valueNode = rootNode.FirstChild;
            int products = int.Parse(valueNode.InnerText);
            

            //more products part
            for (int i = 1; i < products; i++)
            {


                //load data from database

                ds = product.GetProduct(i);
                dt = ds.Tables[0];
                dr = dt.Rows[0];
                int category = Convert.ToInt16(dr["CategoryID"]);
                if (category == cat)
                {


                    nameProduct = Convert.ToString(dr["ProductName"]);
                    specs = Convert.ToString(dr["Specification"]);
                    expDate = Convert.ToString(dr["ExpiryDate"]);
                    int price = Convert.ToInt16(dr["DiscountedPrice"]);
                    specification = specs.Replace(";", "</br>");

                    additionalItems.InnerHtml += "<div class='col-xs-3 iteminfo'>" +
                        "<a href='/Details.aspx?productno=" + i + "'>" +
                            "<img class='img-circle' src='UploadedImages/product" + i + ".jpg' width='100' height='100' /></a><h2>" + nameProduct + "</h2>" +
                            "<p>" + specification + "</br>" +
                            "Price: Rs." + price + "</br>" +
                            "Expires On: " + expDate + "</p>" +

                            "<p><a class='btn btn-default' href='/Details.aspx?productno=" + i + "' role='button'>View details &raquo;</a></p>" +
                    "</div>";
                }
            }
        }
    }
}