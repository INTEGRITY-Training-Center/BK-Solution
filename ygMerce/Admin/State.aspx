<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="ygMerce.State" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>State Form</h1>
                <div class="form-horizontal">
                <div class="form-group">
                    <asp:TextBox ID="TextBox1" placeholder="DivisionName" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtDivisionName" placeholder="DivisionName" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                    
                <div class="form-group">
                        <asp:TextBox ID="txtDivisionDescription" placeholder="DivisionDescription" cssclass="form-control"  runat="server"></asp:TextBox>

                </div>
                    
                <div class="form-group">
                    <asp:TextBox ID="txtCountryID" placeholder="CountryID" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                <div class="form-group">
                    <asp:Button ID="btnSaveState" OnClick="btnSaveState_Click" cssclass="btn btn-success form-control" runat="server" Text="Save" />

                </div>
                </div>
            </div>

        </div>


    </div>
    
    
    
    
     <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
