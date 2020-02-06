<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="ygMerce.Inventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Form_Style_HLT.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="header row bg-primary">
            <div class="col-sm-12">
                <h1>Inventory</h1>
            </div>
        </div>

        <div class="content row">
            <div class="col-sm-2"></div>
            <div class="col-sm-8 overflow">
                <h2>Inventory List</h2>
                <asp:GridView Style="width: 100%;" ID="invenGv" runat="server"></asp:GridView>
            </div>
            <div class="col-sm-2"></div>
        </div>

        <div class="content row">

            <div class="col-sm-2"></div>

            <div class="col-sm-8">
                <h2>Insert New Customer</h2>
                <form class="form-horizontal">
                    <div class="form-group">
                        <asp:Label ID="lblProductName" runat="server" Text="ProductName"></asp:Label>
                        <asp:DropDownList ID="ProductData" DataTextField="ProductName" DataValueField="ProductID" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="Quantity" runat="server" Text="Quantity"></asp:Label>
                        <asp:TextBox ID="txtProductQtty" placeholder="Quantity" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox><br />
                        <br />
                    </div>
                    <asp:Button class="btn btn-primary form-control" ID="btnSave" OnClick="btnSave_Click" runat="server" Text="Save" />
                </form>
            </div>
            <div class="col-sm-2"></div>
        </div>

        <div class="footer row bg-primary ">
            <div class="col-sm-12">
                <p>Footer.....</p>
            </div>
        </div>

    </div>

</asp:Content>
