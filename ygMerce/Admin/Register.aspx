<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ygMerce.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1>Register Form</h1>
                <div class="form-horizontal">
                <div class="form-group">
                    <asp:TextBox ID="txtUserName" placeholder="UserName" cssclass="form-control" runat="server"></asp:TextBox>
                    

                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtNRC" placeholder="NRC" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                     <div class="form-group">
                    <asp:TextBox ID="txtDOB" placeholder="DOB" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                     <div class="form-group">
                    <asp:TextBox ID="txtPicture" placeholder="Picture" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                     <div class="form-group">
                    <asp:TextBox ID="txtAddress" placeholder="Address" cssclass="form-control"  runat="server"></asp:TextBox>

                </div>
                    <div class="form-group">
                    <asp:TextBox ID="txtGender" placeholder="Gender" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                    <div class="form-group">
                    <asp:TextBox ID="txtPhone" placeholder="Phone" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                    <div class="form-group">
                     <asp:TextBox ID="txtPassword" placeholder="Password" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                    <div class="form-group">
                    <asp:TextBox ID="txtEmail" placeholder="Email" cssclass="form-control" runat="server"></asp:TextBox>

                </div>
                    <div class="form-group">
                    <asp:TextBox ID="txtInsertDate" placeholder="InsertDate" cssclass="form-control" runat="server"></asp:TextBox>


                </div>
                    
                    <div class="form-group">
                    <asp:TextBox ID="txtUpdateDate" placeholder="UpdateDate" cssclass="form-control" runat="server"></asp:TextBox>


                </div>
                <div class="form-group">
                    <asp:Button ID="btnSaveRegister" OnClick="btnSaveRegister_Click" cssclass="btn btn-success form-control" runat="server" Text="Save" />

                </div>
                </div>
            </div>

        </div>


    </div>
    
     <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
