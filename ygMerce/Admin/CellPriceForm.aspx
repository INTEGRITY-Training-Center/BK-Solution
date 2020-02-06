<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true"
     CodeBehind="CellPriceForm.aspx.cs" Inherits="ygMerce.CellPriceForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                
            
             <h1>Cell_Price Form</h1>
                <div class="form-horizontal">

                    <div class="form-group">

<asp:TextBox ID="txtProduct_ID" placeholder="ID" cssClass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                 <asp:TextBox ID="txtCell_Price1" placeholder="e.g Cell_Price1" cssClass="form-control" runat="server"></asp:TextBox>
            </div>
                    <div class="form-group">
                 <asp:TextBox ID="txtUn_M_ID" placeholder="e.g Un_M_ID" cssClass="form-control" runat="server"></asp:TextBox>
            </div>
                    <div class="form-group">
                 <asp:TextBox ID="txtCell_Price2" placeholder="e.g Cell_Price2" cssClass="form-control" runat="server"></asp:TextBox>
            </div>
                    <div class="form-group">
                 <asp:TextBox ID="txtInsertDate" placeholder="e.g dd//mm//yyyy" cssClass="form-control" runat="server"></asp:TextBox>
            </div>
                    <div class="form-group">
                 <asp:TextBox ID="txtUpdateDate" placeholder="e.g dd//mm//yyyy" cssClass="form-control" runat="server"></asp:TextBox>
            </div>
                 <div class="form-group">
                <asp:Button ID="btnSaveCell_Price" OnClick="Button1_Click1" cssClass="btn btn-success form-control" runat="server" Text="Save" />
                </div>
        </div>
            </div>  
    </div>
   </div>
    <asp:GridView ID="gVCell_Price" runat="server"></asp:GridView>
</asp:Content>
