<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Reorder.aspx.cs" Inherits="ygMerce.Reorder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Reorder Form</h1>
                <div class="form-horizontal">
                <div class="form-group">
                    <asp:TextBox ID="txtProductID" placeholder="ProductID" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtInventoryID" placeholder="InventoryID" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                    
                <div class="form-group">
                    <asp:TextBox ID="txtReorderUnit" placeholder="ReorderUnit" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:Button ID="btnSaveReorder" OnClick="btnSaveReorder_Click" cssclass="btn btn-success form-control" runat="server" Text="Save" />

                </div>
                </div>
            </div>

        </div>


    </div>
    
    
    
    
    


    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
