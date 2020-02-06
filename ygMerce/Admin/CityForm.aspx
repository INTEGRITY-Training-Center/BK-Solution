<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="CityForm.aspx.cs" Inherits="ygMerce.CityForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                
            
             <h1>City Form</h1>
                <div class="form-horizontal">

                    <div class="form-group">

<asp:TextBox ID="txtCity_Name" placeholder="e.g City" cssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                 <asp:TextBox ID="txtCity_Description" placeholder="e.g City_Description" cssClass="form-control" runat="server"></asp:TextBox>
            </div>
                    <div class="form-group">
            </div>
                 <div class="form-group">
                <asp:Button ID="btnSaveCity" OnClick="btnSaveCity_Click" cssClass="btn btn-success form-control" runat="server" Text="Save" />
                </div>
        </div>
      </div>            
    </div>
   </div>
  <asp:GridView ID="gVCity_form" runat="server"></asp:GridView>
</asp:Content>
