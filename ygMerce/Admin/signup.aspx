<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="ygMerce.Admin.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link href="css/bs/css/bootstrap.css" rel="stylesheet" />--%>
    <link href="../lib/bootstrap/dist/css/bootstrap.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/fontawesome.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/solid.min.css" rel="stylesheet" />
    <link href="../lib/fontawesome/css/brands.css" rel="stylesheet" />
    <link href="../lib/page.css" rel="stylesheet" />


    <style>
        
        @font-face {
            font-family: 'phs';
            src: url('../lib/Pyidaungsu-2.5_Regular.ttf') format('truetype');
        }

        .catlist, .account-box h4 span{font-family:'phs' !important;}

        .bg-accpunt-pages{
            background: linear-gradient(to left, #a644e4, #56c8b8);

        }
        
        
        i.fa-window-maximize{
            padding:5px;
            border-radius:3px;
        }
        .account-logo-box.hv:hover i.fa-window-maximize, .account-logo-box.phv:hover i.fa-window-maximize
        {
            background-color:#d5d5d5a8;
        }

        .account-logo-box.hv i.fa-window-maximize::before {
            /*content: "\f2d0";*/
             content: "\f141";
        }
        .account-logo-box.phv i.fa-window-maximize::before{
             /*content: "\f2d0";*/
              content: "\f141";
        }
        .account-logo-box.hv i.fa-window-maximize.ON::before {
            content: "\f141";
        }

        .account-logo-box.phv i.fa-window-maximize.PON::before {
            content: "\f141";
        }

        .mini.minimixiON, .kiki.minimixiPON {
            /*content: "\f2d1";*/
            display: block;
            transition: display 2s;
        }
        .mini.minimixiOFF, .kiki.minimixiPOFF { /*content: "\f2d1";*/
            display: none;
            transition: display 2s;
        }
        #minimixer {
            z-index: 1000;
        }

            #minimixer:hover {
                cursor: pointer;
            }

        .account-logo-box.hv, .account-logo-box.phv {
            background-color: transparent;
            border-bottom: 1px solid #fff;
        }
            .account-logo-box.hv > h5, .account-logo-box.phv > h5 {
                display: inline-block;
            }

            .account-logo-box.hv:hover, .account-logo-box.phv:hover {
                cursor: pointer;
                background-color: #175c81;
                transition: background-color 0.5s;
            }

      

        .account-pages {
            display: initial;
        }
        a i.fa-plus-square, a i.fa-window-close{
            color:white;
            font-size:1.3em;
            vertical-align: -webkit-baseline-middle;
        }
        a i.fa-plus-square:hover{
            color:black;
        }

            a i.fa-window-close:hover {
                color:red;
            }
            a #ifa:hover{
                color:transparent;
            }

        .account-box {
            position: relative;
            max-width: 460px;
            margin: 20px auto;
             background-color: transparent; 
            border-radius: 0;
            border: 1px solid #fff;
        }
        .cat input.form-control{
            margin-bottom:10px;
            color: #0e243a;
    background-color: transparent;
    background-clip: padding-box;
    border: 1px solid #102e4c;
        }
    </style>
</head>
<body class="bg-accpunt-pages">
    
     <form class="form-horizontal" runat="server" id="form1">
 <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

   
    <section>
        <div class="container-fluid">
            <div class="row">

                <!-- New Category -->
                <div class="col-md-3 cat">
                    <div class="account-pages">
                            <div class="account-box" style="">
                                <div class="account-logo-box hv" style="padding: 18px 30px 7px 13px;  ">
                                    <div class="row">
                                        <div class="col-10">
                                            <h4 class="fa fa-list-alt text-left" style="                                                    display: block;
                                                    text-align: center;
                                                    color: #fff;
                                                    font-size: initial;
                                            ">
                                              <span>အမျိုးအစား သတ်မှတ်ခြင်း</span> 
                                                
                                            </h4>
                                            
                                        </div>
                                        <div class="col-2 text-right" id="minimixer" > 
                                            <a  style="color: white; margin-top: -4px; display: block; margin-left: 20px;"><i class="fa fa-window-maximize ON"></i></a>
                                        </div>
                                    </div>


                                </div>
                               
                                <div class="account-content pt-1 pb-1 pl-1 pr-1 mini minimixiON" >
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                             <div class="form-group m-b-20 mt-2" >
                                            <div class="row ml-0 mr-0" >
                                            <div class="col-md-12 p-0" id="appendtextbox" runat="server">
                                                <label for="txtType" class="d-none">Category Type</label>
                                                <input name="txtDynamic0"  type="text" id="txtDynamic0" runat="server" class="form-control col-9 float-left" autocomplete="off" placeholder="" required />
                                            <a href="#" runat="server" id="aButton" onserverclick="btnAddTextBox_Click" class="addtextbox col-1 float-left" style=""><i class="fas fa-plus-square fa-lg" ></i></a>
                                               <a  runat="server" id="acButton"   class="addtextbox col-1 float-left" style=""><i id="ifa" class="fas fa-window-close fa-lg disabled" style=""></i></a>
                                               
                                                <%--<asp:LinkButton ID="LB" runat="server" CommandArgument='<%# Eval("ID") %>' OnClick="btnRemove_Click">LinkButton</asp:LinkButton>
                                              --%>  </div>
                                            <div class="col-md-1 pl-3 mt-2" style="" id="appendbutton" runat="server">
                                                
                                            </div>
                                                </div>
                                        </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                       

                                        <div class="form-group m-b-20 d-none">
                                            <div class="col-xs-12">
                                                <label for="txtDescription">Description</label>
                                                <input name="txtDescription" type="tel" id="txtDescription" class="form-control" autocomplete="off" placeholder="အေအးဗူး/ အေအးပုလင္း/ ေဖ်ာ္ရည္" required="">
                                            </div>
                                        </div>

                                        



                                       
                                  







                                </div>
                                <div class="account-logo-box mini minimixiON" style="padding: 6px 13px 6px 13px;background-color: transparent;border-top:1px solid #fff;">
                                    <div class="row">
                                        <div class="col-12">
                                            
                                        
                                            <div class="col-md-4 offset-8 p-0 text-right">
                                                
                                                
                                               
                                                
                                              <button type="button" class="btn btn-sm btn-primary mt-0 w-auto " runat="server" id="Btnconfirm1" onserverclick="Btnconfirm_Click" ><i class="fas fa-save"></i>&nbsp; Save</button>

                                                <%--<asp:Button ID="Btnconfirm" CssClass="btn btn-primary mt-0 w-auto" runat="server" Text=" Save" ValidationGroup="a" OnClick="Btnconfirm_Click" />--%>
                                                
                                               

                                            </div>
                                          
                                          
                                       
                                            
                                        </div>
                                    </div>


                                </div>
                            </div>
                        </div>

                    <div class="account-pages">
                            <div class="account-box" >
                                <div class="account-logo-box phv" style="padding: 18px 30px 7px 13px;  ">
                                    <div class="row">
                                        <div class="col-10">
                                            <h4 class="fas fa-box text-left" style="display: block; text-align: center;color:#fff;font-size:initial;">
                                               <span>ရောင်းကုန် သတ်မှတ်ခြင်း </span>
                                                
                                            </h4>
                                            
                                        </div>
                                        <div class="col-2 text-right" id="" > 
                                            <a  style="color:white;margin-top: -4px;display: block;margin-left: 20px;"><i class="fa fa-window-maximize kiki PON"></i></a>
                                        </div>
                                    </div>


                                </div>
                                
                                <div class="account-content pt-1 pb-1 pl-1 pr-1 kiki minimixiON" >
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <ContentTemplate>
                                            <div class="form-group m-b-20 mt-2">
                                                <asp:Repeater ID="rptMainList" runat="server">
                                                    <ItemTemplate>
                                                        <div class="row ml-0 mr-0">
                                                            <div class="col-md-10 p-0 catlist" id="Div1" runat="server">

                                                                <%--testProductDetails.aspx?productID=<%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "ProductID"))) %>--%>
                                                                <a href="#">
                                                                    <%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "Type"))) %></span>
                                                                </a>

                                                            </div>

                                                        </div>
                                                    </ItemTemplate>
                                                </asp:Repeater>
                                        </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                       

                                        <div class="form-group m-b-20 d-none">
                                            <div class="col-xs-12">
                                                <label for="txtDescription">Description</label>
                                               
                                            </div>
                                        </div>

                                </div>
                             
                            </div>
                        </div>
                </div>

                <div class="col-6"></div>
                 <!-- New Customer -->
                <div class="col-md-3">

                    <div class="wrapper-page">

                        <div class="account-pages">
                            <div class="account-box">
                                <div class="account-logo-box">
                                    <div class="row">
                                        <div class="col-12">
                                            <h5 class="fa fa-user-check fa-lg text-center" style="                                                    display: block;
                                                    text-align: center;
                                                    color: #0419a9;
                                                    font-size: initial;
                                            ">
                                                Hi New Customer!
                                                
                                            </h5>
                                            <h6 style="font-size:initial;text-align:center;">Welcome to BK</h6>
                                        </div>
                                    </div>


                                </div>
                                <div class="account-content pt-1 pb-1">
                                   
                                        <%--<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true" />--%>
                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">
                                                <label for="txtName">Customer Name</label>
                                                <asp:TextBox ID="txtName" runat="server" autocomplete="off" CssClass="form-control" placeholder="Daw Mya" Required></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">
                                                <label for="txtMobileNo">Phone No</label>
                                                <asp:TextBox ID="txtMobileNo" TextMode="Phone" autocomplete="off" runat="server" CssClass="form-control" placeholder="09444450220" Required></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">
                                                <label for="txtAddress">Address</label>
                                                <asp:TextBox ID="txtAddress" runat="server" autocomplete="off" TextMode="MultiLine" CssClass="form-control" placeholder="Enter Your Address" Required></asp:TextBox>
                                            </div>
                                        </div>

                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">

                                                <label for="txtpw" class="col-md-7 col-xs-7 p-0" >Password</label> 
                                                <%--<a href="forget.aspx" class="text-muted  col-md-4 col-xs-4" ><small>Forgot your password?</small></a>--%>
                                                <%--<input name="password" runat="server" type="password" id="password"  class="form-control" required="" placeholder="Enter your password" />--%>

                                                <asp:TextBox ID="txtpw" runat="server" autocomplete="off" CssClass="form-control" TextMode="Password" placeholder="Enter Your Password"  Required ></asp:TextBox>
                                                
                                            </div>
                                        </div>
                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">

                                                <label for="txtretypepw" class="col-md-7 col-xs-7 p-0" >Confirm Password</label>
                                                <asp:TextBox ID="txtretypepw" autocomplete="off" CssClass="form-control"  runat="server" TextMode="Password" placeholder="Retype Your Password"  Required></asp:TextBox>
                                                     
                                            </div>
                                        </div>



                                        <div class="form-group">
                                         <%--   <div class="row">
                                                  <div class=" col-md-8 ">
                                                      <div class="custom-control custom-checkbox mb-3">
                                                          <input type="checkbox" class="custom-control-input" runat="server" id="customCheck" name="example1" />
                                                          <label class="custom-control-label" for="customCheck">Remember Me!</label>
                                                      </div>
                                            </div>--%>
                                            <div class="col-md-4 offset-8 p-0 text-right" >
                                                
                                                
                                                <asp:Button ID="btnSubmit" runat="server" Text="Submit"  CssClass="btn btn-primary mt-1 " ValidationGroup="b" OnClick="btnSubmit_Click" />
                                                   
                                                    <%--<button type="button" class="btn btn-primary mt-1 w-100" runat="server" id="btnSign" onclick="BtnSignIn_Click"><i class="fas fa-sign-in-alt"></i>&nbsp; Login</button>--%>
                                                <%--<input type="submit" name="btnSignin" value="Sign In" id="btnSignin" class="btn  btn-primary col-md-12 ">--%>
                                           


                                               




                                                <div id="status">
                                                </div>

                                            </div>
                                          
                                          
                                        </div>
                                  







<%--                                    <div class="row m-t-50" >
                                        <div class="col-sm-12 text-center">
                                            <p class="text-muted">Don't have an account? <a href="Profile.aspx" class="text-dark m-l-5"><b>Sign Up</b></a></p>
                                        </div>
                                        <div id="displayUpdates"></div>
                                        <div id="displayUpdates1"></div>

                                        <div id="account-info"></div>
                                        <div id="recommendations"></div>
                                    </div>--%>

                                </div>
                            </div>
                        </div>
                        


                    </div>
                   

                </div>
            </div>



        </div>
    </section>
    </form>
    
<script src="../lib/bootstrap/dist/js/bootstrap.js"></script>
<script src="../lib/bootstrap/dist/js/bootstrap.bundle.js"></script>
<script src="../lib/fontawesome/js/fontawesome.js"></script>
    <script src="../js/jquery-3.2.1.min.js"></script>


    <script>
        $(document).ready(function () {
          
            var $class2 = $('.account-logo-box.hv');

            $([$class2]).each(function () {
                $(this).on('click', function (e) {
                    if ($(".account-logo-box.hv i.fa-window-maximize ").hasClass("ON")) {
                        $(".account-logo-box.hv i.fa-window-maximize ").removeClass("ON");
                    }
                    else {
                        $(".account-logo-box.hv i.fa-window-maximize ").addClass("ON");
                    }


                    if ($(".mini").hasClass("minimixiON")) {
                        $(".mini").removeClass("minimixiON");
                        $(".mini").addClass("minimixiOFF");

                    }
                    else {
                        $(".mini").removeClass("minimixiOFF");
                        $(".mini").addClass("minimixiON");


                    }
                })
            });
         
            $('.account-logo-box.phv').click(function () {
                if ($(".account-logo-box.phv i.fa-window-maximize.kiki").hasClass("PON")) {
                    $(".account-logo-box.phv i.fa-window-maximize.kiki").removeClass("PON");
                }
                else {
                    $(".account-logo-box.phv i.fa-window-maximize.kiki").addClass("PON");
                }
                if ($(".kiki").hasClass("minimixiON")) {
                    $(".kiki").removeClass("minimixiON");
                    $(".kiki").addClass("minimixiOFF");

                }
                else {
                    $(".kiki").removeClass("minimixiOFF");
                    $(".kiki").addClass("minimixiON");


                }
            });

        });
    </script>

        

            
   
</body>
</html>
