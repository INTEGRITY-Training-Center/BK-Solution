<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="tstProduct.aspx.cs" Inherits="ygMerce.tstProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/plugins/bootstrap-fileupload/bootstrap-fileupload.css" rel="stylesheet" />
    <link href="/plugins/bootstrap-datepicker/css/bootstrap-datepicker.min.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br /><br />
    <div class="container">
        <div class="row">
            <div class="col-md-2">
                    Main :
                 <img id="blah" src="img/images.png" alt="Your Photo" class="fileupload-preview fileupload-exists thumbnail" width="100%" height="100%" />
                      
            </div>
             <div class="col-md-2">
                  Left :
                 <img id="blah1" src="img/images.png" alt="Your Photo" class="fileupload-preview fileupload-exists thumbnail" width="100%" height="100%" />
                
            </div>
             <div class="col-md-2">
                  Right :
                 <img id="blah2" src="img/images.png" alt="Your Photo" class="fileupload-preview fileupload-exists thumbnail" width="100%" height="100%" />
                
            </div>
             <div class="col-md-2">
                   Top :
                 <img id="blah3" src="img/images.png" alt="Your Photo" class="fileupload-preview fileupload-exists thumbnail" width="100%" height="100%" />
                
            </div>
             <div class="col-md-2">
                  Behind :
                 <img id="blah4" src="img/images.png" alt="Your Photo" class="fileupload-preview fileupload-exists thumbnail" width="100%" height="100%" />
                
            </div>
             <div class="col-md-2">
                  Bottom :
                 <img id="blah5" src="img/images.png" alt="Your Photo" class="fileupload-preview fileupload-exists thumbnail" width="100%" height="100%" />
                
            </div>
        </div>
    </div>

    <div class="container">
        <div class="row">
            <div class="col-md-2 ">
                                   
                <asp:FileUpload ID="fuMain" runat="server" CssClass="btn btn-info btn-block " onchange="readURL(this)" required  />
            </div>
            <div class="col-md-2">
                
               
                <asp:FileUpload ID="fuLeft" runat="server"  CssClass="btn btn-info btn-block " onchange="readURL1(this)"  />
            </div>
            <div class="col-md-2">
               
                <asp:FileUpload ID="fuRight" runat="server" CssClass="btn btn-info btn-block " onchange="readURL2(this)"  />
            </div>
            <div class="col-md-2">
              
                <asp:FileUpload ID="fuFront" runat="server"  CssClass="btn btn-info btn-block " onchange="readURL3(this)"  />
            </div>
            <div class="col-md-2">
               
                <asp:FileUpload ID="FuBehind" runat="server"  CssClass="btn btn-info btn-block " onchange="readURL4(this)" />
            </div>
            <div class="col-md-2">
               
                <asp:FileUpload ID="fuBottom" runat="server"  CssClass="btn btn-info btn-block "  onchange="readURL5(this)" />
            </div>
        </div>
    </div>
    <br />
     <div class="container">
         <div class="row">
              <div class="col-md-3">
                     <asp:DropDownList ID="ddlCateogry" AutoPostBack="true" OnSelectedIndexChanged="ddlCateogry_SelectedIndexChanged" runat="server" DataValueField="CategoryID" CssClass="btn btn-success btn-block  dropdown-toggle"></asp:DropDownList>
   
             </div>

             <div class="col-md-3">
                  <asp:DropDownList ID="ddlBrand" runat="server" DataValueField="BrandID" CssClass="btn btn-success btn-block dropdown-toggle"></asp:DropDownList>
  
             </div>
              <div class="col-md-3">
                     <asp:DropDownList ID="ddlSupplier" runat="server" DataValueField="SupplierID" CssClass="btn btn-success btn-block  dropdown-toggle"></asp:DropDownList>
  
             </div>
             
              <div class="col-md-3">
                   <asp:DropDownList ID="ddlUM" runat="server" DataValueField="UMID" CssClass="btn btn-success btn-block  dropdown-toggle"></asp:DropDownList > 
             </div>
         </div>
     </div>
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-3">
                <asp:TextBox ID="txtProductName" runat="server" placeholder="Product Name" CssClass="input-sm form-control" required></asp:TextBox>
   
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="txtColor" runat="server" placeholder="Product Color" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
            <div class="col-md-3">
                 <asp:TextBox ID="txtSize" runat="server" placeholder="Size" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="txtMade" runat="server" placeholder="Made" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
            

            
        </div>
        </div>
    <br />
      <div class="container">
        <div class="row">
            <div class="col-md-3">
                 <asp:TextBox ID="txtUnitStock" runat="server" placeholder="UnitInStock" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
            <div class="col-md-3">
                 <asp:TextBox ID="txtBuyPrice" runat="server" placeholder="Buy Price" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
            <div class="col-md-3">
                 <asp:TextBox ID="txtReorder" runat="server" placeholder="Reorder Unit" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
            <div class="col-md-3">
                <asp:TextBox ID="txtSellPrice" runat="server" placeholder="Sell Price" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
        </div>
          </div>
    <br />

      <div class="container">
        <div class="row">
            <div class="col-md-3">
     <div class="form-group">
                <div class='input-group date'>
                     <asp:TextBox ID="txtManuDate" runat="server" placeholder="Entry Date" CssClass="input-sm form-control datepicker" autocomplete="off" required></asp:TextBox>
                    <span class="input-group-addon">
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>
               </div>    
             <div class="col-md-3">
                 <div class="form-group">
                <div class='input-group date'>
                     <asp:TextBox ID="txtExpDate" runat="server" placeholder="Expire Date" CssClass="input-sm form-control datepicker " autocomplete="off" required></asp:TextBox>
                    <span class="input-group-addon">
                        <span class="glyphicon glyphicon-calendar"></span>
                    </span>
                </div>
            </div>
                
            </div>
             <div class="col-md-3">
                  <asp:TextBox ID="txtDesc" TextMode="MultiLine" runat="server" placeholder="Product Details" CssClass="input-sm form-control" required></asp:TextBox>
            </div>
             <div class="col-md-3">
                 <asp:Button ID="btnSave" runat="server" Text="Save Product" OnClick="btnSave_Click" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
    
    <script src="assets/js/jquery.min.js"></script>
     <script src="/plugins/jquery-ui/jquery-ui.min.js"></script>
    <script src="/plugins/bootstrap-datepicker/js/bootstrap-datepicker.min.js"></script>
   
       <script>
        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }
        function readURL1(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah1').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }
        function readURL2(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah2').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }
        function readURL3(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah3').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }
        function readURL4(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah4').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }
        function readURL5(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#blah5').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }
        //$("#filePhoto").change(function () {
        //    readURL(this);
        //});
   </script>
    <script>
        jQuery('.datepicker').datepicker({
            autoclose: true,
            todayHighlight: true
        });
    </script>

    <script type="text/javascript">
        //$(function () {
        //    $('#datetimepicker1').datetimepicker();
        //});
        </script>
</asp:Content>
