<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="CategoryForm.aspx.cs" Inherits="ygMerce.CategoryForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                
            
             <h1>Category Form</h1>
                <div class="form-horizontal">

                    
                    <div class="form-group">
                        <asp:TextBox ID="txtType" placeholder="e.g Computer" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">

                        <asp:TextBox ID="txtDescription" placeholder="Description" CssClass="form-control" runat="server"></asp:TextBox>

                    </div>
                 <div class="form-group">
                <asp:Button ID="btnSaveCategory" OnClick="btnSaveCategory_Click" cssClass="btn btn-success form-control" runat="server" Text="Save" />
                </div>
        </div>



                </div>

                
    </div>
   </div>
  <asp:GridView ID="gVCategory" runat="server"></asp:GridView>
          
</asp:Content>
