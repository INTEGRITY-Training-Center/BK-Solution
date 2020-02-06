<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="ygMerce.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Form_Style_HLT.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="header row bg-primary">
            <div class="col-sm-12">
                <h1>Customers</h1>
            </div>
        </div>

        <div class="content row">
            <div class="col-sm-2"></div>
            <div class="col-sm-8 overflow">
                <h2>Customer List</h2>
                <asp:GridView Style="width: 100%;" ID="CustomerGv" runat="server"></asp:GridView>
            </div>
            <div class="col-sm-2"></div>
        </div>

        <div class="content row">

            <div class="col-sm-2"></div>

            <div class="col-sm-8">
                <h2>Insert New Customer</h2>
                <form class="form-horizontal">
                    <div class="form-group">
                        <asp:Label ID="lblCustomerCode" runat="server" Text="CustomerCode"></asp:Label>
                        <asp:TextBox ID="txtCustomerCode" placeholder="CustomerCode" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCustomerName" runat="server" Text="CustomerName"></asp:Label>
                        <asp:TextBox ID="txtCustomerName" placeholder="CustomerName" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblTownshipName" runat="server" Text="TownshipName"></asp:Label>
                        <asp:DropDownList ID="townshipData" DataTextField="TownshipName" DataValueField="TownshipID" runat="server" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblContact" runat="server" Text="Contact"></asp:Label>
                        <asp:TextBox ID="txtContact" placeholder="Contact" runat="server" autocomplete="off" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="QuarterName" runat="server" Text="QuarterName"></asp:Label>
                        <asp:DropDownList ID="CustomerAddress" DataTextField="QuarterName" DataValueField="QuarterID" runat="server" CssClass="form-control"></asp:DropDownList>
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
