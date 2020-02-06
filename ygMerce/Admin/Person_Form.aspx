<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="Person_Form.aspx.cs" Inherits="ygMerce.Person_Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
         <div class="row">
             <div class="col-md-12 col-sm-12 col-xs-12 col-lg-12">
            <h1 class="text-primary text-center">PERSON FORM</h1>
            <div class="form-horizontal">
              
                     <div class="form-group">

                    <label for="txtfathernameperson" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">FATHER NAME</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                         <asp:TextBox ID="txtfathernameperson" placeholder="FATHER NAME" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>  

                </div>
                    
                     <div class="form-group">

                    <label for="txtpersonnrc" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">NRC</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                        <asp:TextBox ID="txtpersonnrc" placeholder="NRC" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>  

                </div>
                <div class="form-group">

                    <label for="txtstreeperson" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">STREET</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                       <asp:TextBox ID="txtstreeperson" placeholder="STREET" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>  

                </div>

                 <div class="form-group">

                    <label for="quaterperson" class="control-label col-md-2 col-sm-2 col-xs-2 col-lg-2">QuarterName</label>
                   
                    <div class="col-md-10 col-xs-10 col-sm-10 col-lg-10">

                      <asp:DropDownList ID="quaterperson" DataTextField="QuarterName" CssClass="form-control" runat="server"></asp:DropDownList>
                    </div>  

                </div>
                <div class="col-md-10 col-md-offset-2">
          
                    <asp:Button ID="btnsave" OnClick="btnsave_Click" runat="server" CssClass="btn btn-default" Text="Save" />
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
                          <asp:TemplateField  HeaderText="Father Name">
                 <ItemTemplate>
                     <asp:Label ID="lbltemname" runat="server" Text='<%# Eval("Person_Father_Name")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                               <asp:TemplateField  HeaderText="NRC">
                 <ItemTemplate>
                     <asp:Label ID="lbltemnrc" runat="server" Text='<%# Eval("Person_NRC")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                          <asp:TemplateField  HeaderText="STREET">
                 <ItemTemplate>
                     <asp:Label ID="lbltemstree" runat="server" Text='<%# Eval("Street_Address")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
                           <asp:TemplateField  HeaderText="Quater">
                 <ItemTemplate>
                     <asp:Label ID="lbltemquater" runat="server" Text='<%# Eval("QuarterID")%>'></asp:Label>
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
