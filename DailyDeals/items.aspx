<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="items.aspx.cs" Inherits="DailyDeals.items" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="col-xs-10 col-xs-offset-1 detailinfo detailview itemslist"><br />
        <div class="col-xs-12 itemheader"><h1>All items On Deal Currently:</h1></div>
        <div id="itemcollection" runat="server">
            
        </div>
    </div>
</asp:Content>
