<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="ygMerce.signin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%--<link href="css/bs/css/bootstrap.css" rel="stylesheet" />--%>
    <link href="lib/bootstrap/dist/css/bootstrap.css" rel="stylesheet" />
    <link href="lib/fontawesome/css/fontawesome.css" rel="stylesheet" />
    <link href="lib/fontawesome/css/solid.min.css" rel="stylesheet" />
    <link href="lib/fontawesome/css/brands.css" rel="stylesheet" />
    <link href="lib/page.css" rel="stylesheet" />


    <style>
        .bg-accpunt-pages{
            background: linear-gradient(to left, #a644e4, #56c8b8);

        }
        
    </style>
</head>
<body class="bg-accpunt-pages" onload="OpenNewWP()">
    
       
        <%--<div class="row">
            <div class="col-6 offset-3 bg-light my-5 p-5">
                <div class="row">
                    <div class="col-12">
                        <h3 class="fa fa-plus-square fa-lg text-center" style="display:block; text-align:center;">
                            Soft-HMS
                        </h3>
                    </div>
                </div>
                <div class="col-12">
                    <div  class="text-danger">
                        
                    </div>
                    <div class="col-12">
                        <label class="control-label">
                            Email or PhoneNo
                        </label>
                        <input name="EmailOrPh" type="text"  class="form-control" placeholder="Enter Email or PhoneNo" />
                    </div>
                    <div class="col-12">
                        <label class="control-label">
                            Password
                        </label>
                        <input name="UserPassword" type="password" class="form-control" placeholder="Enter Password" />
                        <span class="text-danger"></span>*
                    </div>

                </div>
                <div class="">
                    <div class="col-4 ml-auto">
                        <button type="button" class="btn btn-success mt-4"><i class="fas fa-sign-in-alt"></i>&nbsp; Login</button>
                        <input type="button" class="btn btn-success mt-4" value="Login" />
                    </div>
                </div>
            </div>
        </div>--%>
    <form id="form2" runat="server">
    <section>
        <div class="container">
            <div class="row">
                <div class="col-sm-12">

                    <div class="wrapper-page">

                        <div class="account-pages">
                            <div class="account-box">
                                <div class="account-logo-box">
                                    <div class="row">
                                        <div class="col-12">
                                            <h3 class="fa fa-shopping-basket fa-lg text-center" style="display: block; text-align: center;color:#0419a9;">
                                                BK
                                            </h3>
                                        </div>
                                    </div>


                                </div>
                                <div class="account-content">
                                    <form class="form-horizontal" action="#">

                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">
                                                <label for="txtmobile">Phone No:</label>
                                                
                                                <asp:TextBox ID="txtmobile" runat="server" CssClass="form-control" Required TextMode="Phone" placeholder="09450057302"></asp:TextBox>
                                            </div>
                                        </div>


                                        <div class="form-group m-b-20">
                                            <div class="col-xs-12">

                                                <label for="txtPassword" class="col-md-7 col-xs-7 p-0" >Password</label> <a href="forget.aspx" class="text-muted  col-md-4 col-xs-4" ><small>Forgot your password?</small></a>
                                              
                                                  <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" Required TextMode="Password" placeholder="Enter Password"></asp:TextBox>
                                            </div>
                                        </div>
                                        


                                        <div class="form-group">
                                            <div class="row">
                                                  <div class=" col-md-8 ">
                                                      <div class="custom-control custom-checkbox mb-3">
                                                          <input type="checkbox" class="custom-control-input" runat="server" id="customCheck"  />
                                                          <%--<asp:CheckBox ID="cbRemember" runat="server" CssClass="custom-control-input" />--%>
                                                          <label class="custom-control-label" for="customCheck">Remember Me!</label>
                                                      </div>
                                            </div>
                                            <div class="col-md-4 ">
                                                
                                               <%-- <i class="fas fa-sign-in-alt"></i>
                                                <asp:Button ID="btnSignIn" runat="server" Text="Sign In"  CssClass="btn btn-primary mt-1 w-100" OnClick="BtnSignIn_Click"/>
                                                --%>
                                                <%--<asp:Button ID="Button1" runat="server" CssClass="btn btn-primary mt-1 w-100" OnClick="BtnSignIn_Click" Text="Log In" />--%>
                                                    <button type="button" class="btn btn-primary mt-1 w-100" runat="server" id="btnSign" onserverclick="BtnSignIn_Click" ><i class="fas fa-sign-in-alt"></i>&nbsp; Login</button>
                                                <%--<input type="submit" name="btnSignin" value="Sign In" id="btnSignin" class="btn  btn-primary col-md-12 ">--%>
                                           


                                         




                                                <div id="status">
                                                </div>

                                            </div>
                                            </div>
                                          
                                        </div>
                                    </form>







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
                        <!-- end card-box-->


                    </div>
                    <!-- end wrapper -->

                </div>
            </div>



        </div>
    </section>
</form>

</body>
    <script>
       
        //var dimensions = 'toolbars=no,menubar=no,location=no,scrollbars=yes,resizable=yes,status=yes';
        //window.opener = self;
        //window.close();
        //window.open('http://localhost:7473/signin.aspx', '_blank', dimensions);

        //window.moveTo(0, 0);
        //window.resizeTo(screen.width, screen.height - 100);

      
        //function OpenNewWP() {
        //    var win = window.open("http://localhost:7473/signin.aspx", "_self", "toolbar=no,height=530,width=960");
        //    win.focus();
        //}


        //function openWindow() {
        //    var browser = navigator.appName;
        //    if (browser =="Microsoft Internet Explorer")
        //    {
        //        window.opener = self;

        //    }
        //    window.open('signin.aspx', 'null', 'width = 900, height = 750, toolbar = no, scrollbars = no, location = no, resizable = yes');
        //    window.moveTo(0, 0);
        //    window.resizeTo(screen.width, screen.height - 100);
        //    self.close();
        //}
    </script>
    <script type="text/javascript">
<!--
    // Use ALT + F4 to close the window while in full screen mode.
    //function toFullScreen() {
    //    if (window.name == 'fullscreen')
    //        return;

    //    var windowRef = window.open('', 'fullscreen', 'fullscreen=yes');
    //    windowRef.location = window.location.href;
        
    //    window.open('', '_self');
    //    window.close();
    //}
        
       
    //    window.moveTo(0, 0);
    //    window.resizeTo(screen.availWidth, screen.availHeight);
    //    window.onload = toFullScreen;

        //function PageReSize() {
        //    if (window.screenY == 0 && window.screenX == 0) {
        //        var window_dimensions = "toolbars=no,menubar=no,location=no,scrollbars=yes,resizable=yes,status=yes";
        //        window.opener = self;
        //        window.open(window.location.href, "null", window_dimensions);
                
                
        //    }
        //}
        //window.onload = PageReSize;
        //window.resizeTo(screen.width, screen.height);
// -->
       
        //function ToggleFullScreen() {
        //    // UniversalXPConnect privilege is required in Firefox  
        //    try {
        //        if (window.netscape && netscape.security) {
        //            // Firefox  netscape.security.PrivilegeManager.enablePrivilege ("UniversalXPConnect"); 
        //        }
        //    }
        //    catch (e) {
        //        alert("UniversalXPConnect privilege is required for this operation!");
        //        return;
        //    }
        //    if ('fullScreen' in window) { window.fullScreen = !window.fullScreen; }
        //    else {

        //        alert("Your browser does not support this example!");
        //    }
        //}
        //window.onload = ToggleFullScreen;
    </script>
 
<script src="lib/bootstrap/dist/js/bootstrap.js"></script>
<script src="lib/bootstrap/dist/js/bootstrap.bundle.js"></script>
<script src="lib/fontawesome/js/fontawesome.js"></script>
</html>
