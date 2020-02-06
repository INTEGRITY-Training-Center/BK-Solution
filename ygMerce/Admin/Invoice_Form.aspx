<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Invoice_Form.aspx.cs" Inherits="ygMerce.Invoice_Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
  
<div class="container">
    <div class="row">
        <div class="col-md-12 col-sm-12 col-xs-12 col-lg-12">
            <h1 class="text-primary text-center">INVOICE FORM</h1>
            <div class="form-horizontal">
                <div class="form-group">S

                    <label for="txtnoinvoice" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">NO</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                        <asp:TextBox ID="txtnoinvoice" placeholder="NO" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>  

                </div>
                <div class="form-group">

                    <label for="txtnameinvoice" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">ProductName</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                        <asp:TextBox ID="txtnameinvoice" CssClass="form-control" placeholder="ProductName" runat="server"></asp:TextBox>
                    </div>  

                </div>
                 <div class="form-group">

                    <label for="txtqtyinvoice" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">QTY</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                         <asp:TextBox ID="txtqtyinvoice" placeholder="QTY" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>  

                </div>
                <div class="form-group">

                    <label for="txtpriceinvoice" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">Price</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                           <asp:TextBox ID="txtpriceinvoice" placeholder="Price" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>  

                </div>
                 <div class="form-group">

                    <label for="txtamountinvoice" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">Amount</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                          <asp:TextBox ID="txtamountinvoice" CssClass="form-control" Placeholder="Amount" runat="server"></asp:TextBox>
                    </div>  

                </div>
                 
             

            

           

     
        <div class="col-md-10 col-md-offset-2">
            <asp:Button ID="btnsaveinvoice" OnClick="btnsaveinvoice_Click" CssClass="btn btn-default" runat="server" Text="Save" />
        </div>            

            


            </div>

            <br/>
            <br />
            <br />

                  <asp:GridView ID="GridView1" runat="server" HeaderStyle-HorizontalAlign="Left"
                       BackColor="White" RowStyle-Height="60px" Font-Size="13px" BorderColor="#336666" 
                      AutoGenerateColumns="false" BorderStyle="Double" BorderWidth="3px" CellPadding="4" 
                      GridLines="Horizontal" Width="100%">
                      <Columns>

                  <asp:TemplateField  HeaderText="NO">
                 <ItemTemplate>
                     <asp:Label ID="lbltemNO" runat="server" Text='<%# Eval("No")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                           <asp:TemplateField  HeaderText="ProductName">
                 <ItemTemplate>
                     <asp:Label ID="lbltemname" runat="server" Text='<%# Eval("ProductName")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                               <asp:TemplateField  HeaderText="Qty">
                 <ItemTemplate>
                     <asp:Label ID="lbltemqty" runat="server" Text='<%# Eval("Qty")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

                       
              <asp:TemplateField  HeaderText="Price">
                 <ItemTemplate>
                     <asp:Label ID="lbltemprice" runat="server" Text='<%# Eval("Price")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

                                      
              <asp:TemplateField  HeaderText="Amount">
                 <ItemTemplate>
                     <asp:Label ID="lbltemamount" runat="server" Text='<%# Eval("Amount")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>




                      </Columns>


<FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />

                      </asp:GridView>
        </div>

    </div>

           

          
                
    </div>


    
    
</asp:Content>
