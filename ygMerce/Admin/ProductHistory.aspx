<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="ProductHistory.aspx.cs" Inherits="ygMerce.ProductHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <asp:TextBox ID="txtproductname" runat="server" placeholder="ProductName"></asp:TextBox>
        <asp:TextBox ID="txtproductimage" runat="server" placeholder="ProductImage"></asp:TextBox>
        <asp:TextBox ID="txtproductdescription" runat="server" placeholder="ProductDescription"></asp:TextBox>
        <asp:TextBox ID="txtproductimageid" runat="server" placeholder="ProductImageId"></asp:TextBox>
        <asp:TextBox ID="txtcatagory" runat="server" placeholder="Catagory"></asp:TextBox>
        <asp:TextBox ID="txtbrandname" runat="server" placeholder="BrandName"></asp:TextBox>
  
     <asp:TextBox ID="txtcolor" runat="server" placeholder="Color"></asp:TextBox>
     <asp:TextBox ID="txtsize" runat="server" placeholder="Size"></asp:TextBox>
     <asp:TextBox ID="txtpruchesprice" runat="server" placeholder="Purches Price"></asp:TextBox>
     <asp:TextBox ID="txtbrandid" runat="server" placeholder="BrandID"></asp:TextBox>
     <asp:TextBox ID="txtmanufacturedate" runat="server" placeholder="ManufactureDate"></asp:TextBox>
     <asp:TextBox ID="txtproductexpiredate" runat="server" placeholder="Product Exipre Date"></asp:TextBox>
     <asp:TextBox ID="txtmanufacturecountry" runat="server" placeholder="Manufacture Country"></asp:TextBox>
     <asp:TextBox ID="txtinserteddate" runat="server" placeholder="Inserted Date"></asp:TextBox>

    <asp:Button ID="btnproducthistorysave" runat="server" Text="Save" OnClick="btnproducthistorysave_Click"/>

    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
