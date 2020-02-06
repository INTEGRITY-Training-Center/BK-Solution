<%@ Page Title="" Language="C#" MasterPageFile="~/ygn.Master" AutoEventWireup="true" CodeBehind="testReg.aspx.cs" Inherits="ygMerce.testReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

   
   
    <style>
        .imgw {
            width:5vw;
            
        }
        .imgw1 {
            width:30vw;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtUserName" CssClass="form-control" required data-error="Please enter Name" runat="server" placeholder="UserName"></asp:TextBox>
                                      
    <asp:TextBox ID="txtNRC" runat="server" placeholder="NRC" required data-error="Please enter NRC"></asp:TextBox>
    <asp:TextBox ID="txtDOB" runat="server" placeholder="DOB" required data-error="Please enter DOB"></asp:TextBox>
    <asp:TextBox ID="txtAddress" runat="server" placeholder="Address" required data-error="Please enter Address"></asp:TextBox>
    <asp:TextBox ID="txtGender" runat="server" placeholder="Gender" required data-error="Please enter Gender"></asp:TextBox>
    <asp:TextBox ID="txtPhone" runat="server" placeholder="Phone" required data-error="Please enter Phone"></asp:TextBox>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" required data-error="Please enter Password"></asp:TextBox>
    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" required data-error="Please enter Email"></asp:TextBox>
    <asp:FileUpload ID="fuPicture" runat="server" />

    <asp:Button ID="btnSaveRegister" runat="server" Text="Save" OnClick="btnSaveRegister_Click" />

    <asp:GridView ID="gvRegister" runat="server" BackColor="White" RowStyle-Height="60px" Font-Size="13px" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
        <Columns>

            <asp:TemplateField HeaderText="Image">

                <ItemTemplate>

                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# "Controller/ImageHandler.ashx?ImID="+ Eval("RegisterID") %>' CssClass="imgw" ImageAlign="Middle"/>

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

    
    <%--<section id="web-form-section" class="web-form-section">
		<div class="container">
			<div class="formrow">
				<div class="col-12">
					<div class="contact-form-title-wrap">
						<h2 class="title-text"><span>Wanna <strong>Talk</strong></span></h2>
						<div class="title-line text-center">
							<span class="short-line"></span>
							<span class="long-line"></span>
						</div><!-- end title-line -->
					</div><!-- end contact-form-title-wrap -->
					<div class="intro-text text-center">
						A wonderful registration for our site.
					</div><!-- end intro-text -->
				</div><!-- end col-12 -->
								
				<!-- start contact form -->
				<div class="col-8 col-offset-2">
					<div class="web-form-box contact-section-bg">
						<div class="web-form-box-wrapper">
							<div class="web-form-wrap">
								<div class="title-box">
									<h3>Your <strong>Info</strong></h3>
								</div><!-- end title-box -->
								
								<!-- start contact form -->
								<div id="msgContactSubmit" class="hidden"></div>
								<form id="contactForm2" class="webform" name="contactform" data-toggle="validator">
									<span class="sub-text">* Required fields</span>
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<input name="fname" id="fname" class="form-control" type="text" > 
										  <div class="input-group-icon"><i class="fa fa-user"></i></div>
										<label class="form-label">Your Name*</label>
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<input name="email" id="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$" class="form-control" type="email" required data-error="Please enter valid Email"> 
										<div class="input-group-icon"><i class="fa fa-envelope"></i></div>
										<label class="form-label">Your Email*</label>
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<input name="phone" id="phone" class="form-control" type="text" required data-error="Please enter valid Phone">
										<div class="input-group-icon"><i class="fa fa-phone"></i></div>
										<label class="form-label">Contact Phone*</label>
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<select name="service" id="service" class="form-control" required data-error="Please Select Service">
											<option value="">--- Select a Sevice* ---</option>
											<option value="App Devlopment">App Devlopment</option>
											<option value="Web Design">Web Design</option>
											<option value="Graphic Design">Graphic Design</option>
											<option value="e-Commerce">e-Commerce</option>
										</select>
										<div class="input-group-icon"><i class="fa fa-cogs"></i></div> 
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<input name="subject" id="subject" class="form-control" type="text" required data-error="Please enter Subject">
										<div class="input-group-icon"><i class="fa fa-book"></i></div>
										<label class="form-label">Subject*</label>
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<textarea rows="3" name="message" id="message" class="form-control" required data-error="Please enter message"></textarea>
										<div class="input-group-icon"><i class="fa fa-pencil"></i></div>
										<label class="form-label">Write comment here*</label>
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<div id="humanCheckCaptchaBox"></div><div id="firstDigit"></div> + <div id="secondDigit"></div> = <input name="humanCheckCaptchaInput" id="humanCheckCaptchaInput" placeholder="" maxlength="3" class="form-control" type="text" required data-error="Please solve Human Check Captcha">
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="checkbox">
											<label><input name="usercopy" id="usercopy" type="checkbox" value="1">Send a copy to my email</label>
										</div>
									</div><!-- end form-group -->
									<div class="form-group">
										<div class="help-block with-errors"></div>
										<div class="checkbox">
											<label><input name="cookieconsent" id="cookieconsent" type="checkbox" value="1" required data-error="Required Consent"> I agree with the <a href="#">Trems &amp; Conditions</a></label>
										</div>
									</div><!-- end form-group -->						
									<div id="processing-image" style="display:none;">
										<img src="images/processing-image.gif" alt="Processing" />
									</div><!-- end processing-image -->
									<div id="submitButtonHolder" class="form-group">
										<button type="submit" id="submit" class="btn btn-custom">Send</button>
									</div><!-- end form-group -->
								</form>
								<!-- end contact form -->
							</div><!-- end form-wrap -->
						</div><!-- end col-6 -->
						<div class="contactInfo-wrapper">
							<div class="contactInfo-wrap">
								<div class="title-box">
									<h3>Contact <strong>Info</strong></h3>
								</div><!-- end title-box -->
								<div class="contact-item">
									<div class="contact-item-inner">
										<div class="contact-icon">
											<i class="fa fa-map-marker"></i>
										</div><!-- end contact-icon -->
										<div class="contact-desc">
											<h4>70 Trent Rd, Luton LU3 1TA</h4>
										</div><!-- end contact-desc -->
									</div><!-- end contact-item-inner -->
								</div><!-- end contact-item -->
								<div class="contact-item">
									<div class="contact-item-inner">
										<div class="contact-icon">
											<i class="fa fa-envelope"></i>
										</div><!-- end contact-icon -->
										<div class="contact-desc">
											<h4><a href="mailto:sales@yourwebsite.com">sales@website.com</a></h4>
										</div><!-- end contact-desc -->
									</div><!-- end contact-item-inner -->
								</div><!-- end contact-item -->
								<div class="contact-item">
									<div class="contact-item-inner">
										<div class="contact-icon">
											<i class="fa fa-phone"></i>
										</div><!-- end contact-icon -->
										<div class="contact-desc">
											<h4><a href="tel:000-0000-0000">+000 0000 0000</a></h4>
										</div><!-- end contact-desc -->
									</div><!-- end contact-item-inner --> 
								</div><!-- end contact-item -->
									
								<!-- Start Social media -->
								<div class="social-holder">
									<h4>Get in touch with us!</h4>
									<ul class="list-inline list-social clearfix">
										<li>
											<a href="#" class="social-icon social-icon-facebook" target="_blank">
												<i class="fa fa-facebook"></i>
											</a>
										</li>
										<li>
											<a href="#" class="social-icon social-icon-twitter" target="_blank">
												<i class="fa fa-twitter"></i>
											</a>
										</li>
										<li>
											<a href="#" class="social-icon social-icon-linkedin" target="_blank">
												<i class="fa fa-linkedin"></i>
											</a>
										</li>
										<li>
											<a href="#" class="social-icon social-icon-gplus" target="_blank">
												<i class="fa fa-google-plus"></i>
											</a>
										</li>
										<li>
											<a href="#" class="social-icon social-icon-youtube" target="_blank">
												<i class="fa fa-youtube"></i>
											</a>
										</li>
										<li>
											<a href="#" class="social-icon social-icon-vimeo" target="_blank">
												<i class="fa fa-vimeo"></i>
											</a>
										</li>
										<li>
											<a href="#" class="social-icon social-icon-pinterest" target="_blank">
												<i class="fa fa-pinterest"></i>
											</a>
										</li>
									</ul>
								</div>
								<!-- End Social media -->
								
							</div><!-- end formrow -->
						</div><!-- end contactInfo-wrapper -->
						<div class="clearfix"></div>
					</div><!-- end web-form-box -->
				</div><!-- end col-8 -->
				
			</div><!-- end formrow -->
			
			<div class="formrow">
				<div class="footer-top col-12">
					<p class="text-center copyright">&copy; 2018 <a href="https://codecanyon.net/user/mgscoder?ref=mgscoder">MGScoder</a> All rights reserved. <a href="https://codecanyon.net/item/web-form-multi-purpose-html-form-with-jquery-validation/21938652?ref=mgscoder" class="footer-site-link">Buy Web Form Script</a></p>
				</div><!-- end col --> 
			</div><!-- end formrow -->
			
		 </div><!-- end container --> 
	</section>--%>

    <div id="dialog" style="display: none">
</div>



   


    
	
</asp:Content>
