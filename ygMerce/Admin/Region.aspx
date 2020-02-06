<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Region.aspx.cs" Inherits="ygMerce.Region" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Region Form</h1>
                <div class="form-horizontal">
                <div class="form-group">
                    <asp:TextBox ID="txtRegionName" placeholder="RegionName" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtRegionDescription" placeholder="RegionDescription" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:Button ID="btnSaveRegion" OnClick="btnSaveRegister_Click" cssclass="btn btn-success form-control" runat="server" Text="Save" />

                </div>
                </div>
            </div>

        </div>


    </div>
          <asp:GridView ID="GridView1" runat="server"></asp:GridView>

</asp:Content>
<a href="Region.aspx">Region.aspx</a>