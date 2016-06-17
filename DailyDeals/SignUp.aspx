<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="DailyDeals.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    
    
        <div class="register-container container">
            <div class="row">
                <div class="register span6">
                    <div class="col-xs-6 col-xs-offset-3 detailinfo detailview signupform">
                        <div class="col-xs-12"><h2 class="formh2">REGISTER TO <span class="red"><strong>Daily Deals</strong></span></h2></div>
                        <div class="col-xs-5"><asp:label CssClass="modal-label" runat="server" ID="lblfName">First Name</asp:label></div>
                        <div class="col-xs-6 errClass"><p id="fNameErr" runat="server"></p></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtfName" runat="server" placeholder="Enter your first name..."/></div>
                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lbllName" runat="server">Last Name</asp:label></div>
                        <div class="col-xs-6"><p id="lNameErr" class="errClass" runat="server"></p></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" runat="server" ID="txtlName" placeholder="Enter your first name..."/></div>
                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblEmail" runat="server">Email</asp:label></div>
                        <div class="col-xs-6"><p id="EmailErr" class="errClass" runat="server"></p></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtEmail" runat="server" placeholder="Enter your email..." CausesValidation="True" TextMode="Email"/></div>
                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblPassword" runat="server">Password</asp:label></div>
                        <div class="col-xs-6"><p id="PasswordErr" class="errClass" runat="server"></p></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtPassword" runat="server" placeholder="Choose a password..." TextMode="Password"/></div>
                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblRePassword" runat="server">ReEnter Password</asp:label></div>
                        <div class="col-xs-6"><p id="rePasswordErr" class="errClass" runat="server"></p></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtRePassword" runat="server" placeholder="Re-Enter password..." TextMode="Password"/></div>
                        <div class="col-xs-5"><asp:label CssClass="modal-label" ID="lblContNo" runat="server">Contact Number</asp:label></div>
                        <div class="col-xs-6"><p id="cNoErr" class="errClass" runat="server"></p></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:TextBox CssClass="form-control sgnbox" ID="txtContNo" runat="server" placeholder="Enter Contact Number..." /></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:RegularExpressionValidator ID="valid1" ControlToValidate="txtContNo" runat="server" ValidationExpression="^([0-9]{1,10})$" ErrorMessage="Please Enter a Valid Phone No." ForeColor="Red"></asp:RegularExpressionValidator></div>
                        <div class="col-xs-10"><asp:label CssClass="modal-label" ID="lblLocation" runat="server">Location</asp:label></div>
                        <div class="col-xs-10 col-xs-offset-1"><asp:DropDownList CssClass="form-control sgnbox" ID="drlocation" runat="server"/></div>
                        <div class="col-xs-10 col-xs-offset-3"><asp:Button runat="server" Text="REGISTER" CssClass="formbutton" ID="regButton" OnClick="regButton_Click"></asp:Button></div>
                        
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
