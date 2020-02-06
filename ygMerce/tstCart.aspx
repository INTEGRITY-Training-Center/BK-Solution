<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="tstCart.aspx.cs" Inherits="ygMerce.tstCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Your Shopping Cart</h2>
    <div>
        <asp:GridView runat="server" ID="gvShoppingCart">

        </asp:GridView>
        <asp:Literal runat="server" ID="ltTest" />
    </div>



</asp:Content>
