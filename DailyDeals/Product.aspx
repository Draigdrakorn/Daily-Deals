<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="DailyDeals.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="register-container container">
            <div class="row">
                <div class="register span6">
                    <div class="col-xs-6 col-xs-offset-3 detailinfo detailview signupform">
                        <div class="col-xs-12"><h2 class="formh2">Add Product</h2></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" runat="server" ID="lblCategory">Category</asp:label></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:DropDownList CssClass="form-control sgnbox" ID="dCategory" runat="server"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblDeal" runat="server">Deal</asp:label></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:DropDownList CssClass="form-control sgnbox" ID="dDeals" runat="server"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblSuppId" runat="server">Supplier</asp:label></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:DropDownList CssClass="form-control sgnbox" ID="dSupplier" runat="server"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblPName" runat="server">Product Name</asp:label></div>
                        <div class="col-xs-6"><asp:RequiredFieldValidator ID="RequiredFieldValidatorPName" runat="server" ErrorMessage="Please Enter the Product Name" ControlToValidate="txtPName" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtPName" runat="server" placeholder="Enter The Product Name" CausesValidation="True"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblSpecs" runat="server">Specification</asp:label></div>
                        <div class="col-xs-6"><asp:RequiredFieldValidator ID="RequiredFieldValidatorSpec" runat="server" ErrorMessage="Please Enter the Specification" ControlToValidate="txtSpec" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtSpec" runat="server" TextMode="MultiLine" Rows="4" placeholder="Enter The Specification(Separate Each Specification with a semicolon)" CausesValidation="True"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblExpDate" runat="server">Expiry Date</asp:label></div>
                        <div class="col-xs-6"><asp:RequiredFieldValidator ID="RequiredFieldValidatorExpDate" runat="server" ErrorMessage="Please Enter the ExpiryDate(YY-MM-DD)" ControlToValidate="txtExpDate" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtExpDate" runat="server" placeholder="Enter The Expiry Date" CausesValidation="True"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblRegPrice" runat="server">RegularPrice</asp:label></div>
                        <div class="col-xs-6"><asp:RequiredFieldValidator ID="RequiredFieldValidatorRegPrice" runat="server" ErrorMessage="Please Enter the Regular Price" ControlToValidate="txtRegPrice" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtRegPrice" runat="server" placeholder="Enter The Regular Price" CausesValidation="True"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblDiscPrice" runat="server">Discounted Price</asp:label></div>
                        <div class="col-xs-6"><asp:RequiredFieldValidator ID="RequiredFieldValidatorDiscPrice" runat="server" ErrorMessage="Please Enter the Discounted Price" ControlToValidate="txtDiscPrice" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtDiscPrice" runat="server" placeholder="Enter The Specification" CausesValidation="True"/></div>

                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblPImage" runat="server">Product Image</asp:label></div>
                        <div class="col-xs-6"><asp:RequiredFieldValidator ID="RequiredFieldValidatorPImage" runat="server" ErrorMessage="Please Upload a Product Image" ControlToValidate="fileUpload" ForeColor="Red"></asp:RequiredFieldValidator></div>
                        <div class="col-xs-10 col-xs-offset-1">
                        <div class="col-xs-4 col-xs-offset-1" style="padding-top: 25px;"><div class="chFilebtn"><p class="fupp">Choose File</p><asp:FileUpload CssClass="form-control sgnbox fupbtn" ID="fileUpload" runat="server" CausesValidation="True"/></div></div>
                        <div class="col-xs-4 col-xs-offset-1 imgbox" style="padding: 0px;"><asp:Image runat="server" ID="uploadedImage" Width="143px" Height="80px"/> </div>
                        </div>
                       
                        <div class="col-xs-10 col-xs-offset-3"><asp:Button runat="server" Text="Upload" CssClass="formbutton" ID="upButton" OnClick="Upload_Click"></asp:Button></div>
                        
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
