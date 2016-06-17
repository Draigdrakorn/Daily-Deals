<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="DailyDeals.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <div class="col-xs-10 col-xs-offset-1 detailinfo detailview" runat="server" id="itemdetails">
        <div class="col-xs-6">
            <img src="#" runat="server" class="image" id="image"/>
        </div>
        <div class="col-xs-4 itemdetails">
            <div class="col-xs-10"><h1 runat="server" id="productName"></h1></div>
            <div class="col-xs-6"><p>Discounted Price:</p></div><div class="col-xs-4"><p runat="server" id="discPrice"></p></div>
            <div class="col-xs-6"><p>Original Price:</p></div><div class="col-xs-4"><p runat="server" id="orgPrice"></p></div>
            <div class="col-xs-6"><p>Discount:</p></div><div class="col-xs-4"><p runat="server" id="discPerc"></p></div>
            <div runat="server" id="specifications">
            </div>
            <div class="col-xs-6"><p>Added On:</p></div><div class="col-xs-4"><p runat="server" id="addDate"></p></div>
            <div class="col-xs-6"><p>Expires On:</p></div><div class="col-xs-4"><p runat="server" id="expireDate"></p></div>
            <div class="col-xs-10"><asp:Button CssClass="btn btn-success btn-block btnchn" runat="server" Text="Buy Now" /></div>
        </div>
    </div>
    <div class="col-xs-10 col-xs-offset-1 detailinfo" runat="server" id="additionalItems">
        <div class="col-xs-10"><h2>Other items you may like!</h2></div>
        
    </div>
    

</asp:Content>

