<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="ygMerce.Country" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Form_Style_HLT.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">

        <div class="header row bg-primary">
            <div class="col-sm-12">
                <h1>Countries</h1>
            </div>
        </div>

        <div class="content row">
            <div class="col-sm-2"></div>
            <div class="col-sm-8 overflow">
                <h2>Country List</h2>
                <asp:GridView Style="width: 100%;" ID="gvCountry" runat="server"></asp:GridView>
            </div>
            <div class="col-sm-2"></div>
        </div>

        <div class="content row">

            <div class="col-sm-2"></div>

            <div class="col-sm-8">
                <h2>Insert New Country</h2>
                <form class="form-horizontal">
                    <div class="form-group">
                        <asp:Label ID="lblCountryName" runat="server" Text="CountryName"></asp:Label>
                        <asp:TextBox ID="txtCountryName" placeholder="CountryName" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblCountryCode" runat="server" Text="CountryCode"></asp:Label>
                        <asp:TextBox ID="txtCountryCode" placeholder="CountryCode" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDescription" runat="server" Text="Description"></asp:Label>
                        <asp:TextBox ID="txtCountryDescription" placeholder="Description" runat="server" CssClass="form-control" autocomplete="off"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblRegion_Name" runat="server" Text="Region_Name"></asp:Label>
                        <asp:DropDownList ID="regionData" DataTextField="Region_Name" DataValueField="RegionID" runat="server" CssClass="form-control"></asp:DropDownList>
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
