using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using Info;
using System.IO;
using System.Xml;


namespace DailyDeals
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string[] filePaths = Directory.GetFiles(Server.MapPath("~/Images/"));
                //List<ListItem> files = new List<ListItem>();
                //foreach (string filePath in filePaths)
                //{
                //    string fileName = Path.GetFileName(filePath);
                //    files.Add(new ListItem(fileName, "~/Images/" + fileName));
                //}

                DataSet ds = new DataSet();
                Productbll vBll = new Productbll();
                Dealsbll oDel = new Dealsbll();
                ds = oDel.GetDeals();
                DataTable dt = ds.Tables[0];
                dDeals.DataSource = dt;
                dDeals.DataTextField = "Description";
                dDeals.DataValueField = "DealID";
                dDeals.DataBind();

                DataSet das;
                Supplierbll oSup = new Supplierbll();
                das = oSup.GetSupplier();
                DataTable dat = das.Tables[0];
                dSupplier.DataSource = dat;
                dSupplier.DataTextField = "BusinessName";
                dSupplier.DataValueField = "SupplierID";
                dSupplier.DataBind();

                DataSet dbs;
                Categorybll oCat = new Categorybll();
                dbs = oCat.GetCategory();
                DataTable dbt = dbs.Tables[0];
                dCategory.DataSource = dbt;
                dCategory.DataTextField = "Description";
                dCategory.DataValueField = "CategoryID";
                dCategory.DataBind();
                

                
               
                
            }
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
   
                    try
                    {
                        Productbll pBll = new Productbll();
                        ProductInfo oPro = new ProductInfo();
                        oPro.ProductName = txtPName.Text;
                        oPro.Specification = txtSpec.Text;
                        oPro.DealID = Convert.ToInt32(dDeals.SelectedValue);
                        oPro.SupplierID = Convert.ToInt32(dSupplier.SelectedValue);
                        oPro.CategoryID = Convert.ToInt32(dCategory.SelectedValue);
                        oPro.ExpiryDate = txtExpDate.Text;
                        oPro.RegularPrice = int.Parse(txtRegPrice.Text);
                        oPro.DiscountedPrice = int.Parse(txtDiscPrice.Text);

                       //xml load
                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(Server.MapPath("ProductUpdate.xml"));
                        XmlNode rootNode = xmlDoc.SelectSingleNode("product");
                        XmlNode valueNode = rootNode.FirstChild;
                        int productUploadNo = int.Parse(valueNode.InnerText);

                        if (fileUpload.HasFile)
                        {
                            string fileExtension = Path.GetExtension(fileUpload.PostedFile.FileName);
                            uploadedImage.ImageUrl = "~/UploadedImages/" + "product" + productUploadNo + fileExtension;
                            var ImagePath = Server.MapPath("~/UploadedImages/") + "product" + productUploadNo + fileExtension;
                            fileUpload.PostedFile.SaveAs(ImagePath);
                            productUploadNo++;
                            valueNode.InnerText = productUploadNo.ToString();
                            //Response.Redirect(Request.Url.AbsoluteUri);
                        }
                        pBll.SaveProduct(oPro);

                        //save xml
                        xmlDoc.Save(Server.MapPath("ProductUpdate.xml"));

                        txtPName.Text = "";
                        txtSpec.Text = "";
                        //txtImagePath.Text = "";
                        




                        Response.Write("Product Saved Succesfully");
                        DataSet ds = new DataSet();

                        
                        

                    }
                    catch (Exception ex)
                    {

                        Response.Write(ex);
                    }
            
                }

        

       

        
    }

    }

