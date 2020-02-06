<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ygMerce._default" %>

<%@ Import Namespace="ygMerceInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style>

        
        .postedimage {
            width: 29vh;
        }

        .div-image {
            min-height: 250px;
        }

        .div-item {
            position: relative;
            box-sizing: border-box;
            vertical-align: top;
            border-radius: 3px;
            background: #fff;
            padding: 0;
            padding: 3px;
            transition: transform .5s;
            -webkit-transform: translateZ(0);
            -moz-transform: translateZ(0);
            -ms-transform: translateZ(0);
            -o-transform: translateZ(0);
            transform: translateZ(0);
            border: 1px solid #ddd;
            padding-top: 12px;
            margin-right: 20px;
            margin-bottom: 12px;
            margin-top: 12px;
            margin-left: 20px;
        }

            .div-item:hover {
                transition: opacity 2s cubic-bezier(.165,.84,.44,1);
                box-shadow: 0 8px 17px 0 rgba(138,57,3,.2), 0 6px 20px 0 rgba(0,0,0,.15);
                cursor: pointer;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="text-align: center;">
        <div class="my-2 my-lg-0">
            <asp:DropDownList ID="ddlCategories" runat="server" DataTextField="Type" DataValueField="CategoryID"
                OnSelectedIndexChanged="ddlCategories_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox1" runat="server" Width="40%" placeholder="-- search your choices --" CssClass="text-center"></asp:TextBox>
            <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
        </div>
    </div>

    <div style="margin-top: 2em;"></div>


    <div class="container-fluid" style="background: #f2f3f7;">

        <div class="row">




            <asp:Repeater ID="rptMainList" runat="server">
                <ItemTemplate>
                    <div class="div-item col-md-2">

                        <div class="col-md-12">
                            <div class="div-image">
                                <a class="" href="testProductDetails.aspx?productID=<%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "ProductID"))) %>" target="_blank">
                                    <%# listingImage((Productinfo)Container.DataItem) %>
                                </a>

                            </div>
                            <div class="div-info">
                                <div class="div-item-desc">
                                    <a href="testProductDetails.aspx?productID=<%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "ProductID"))) %>">
                                        <%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "ProductName"))) %></span>
                                    </a>
                                </div>
                                <div class="div-item-pmo">

                                    <div class="price" <%--title="US $1-19.9 / Piece"--%>>

                                        <b>US <span class="media-heading">
                                            <a href="testProductDetails.aspx?productID=<%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "ProductID"))) %>">
                                                <%# (Convert.ToString(DataBinder.Eval(Container.DataItem, "UnitPrice"))) %></span>
                                            <span class="unit">/ Piece
                                                         </a>
                                        </b>


                                        </span>


                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>


        </div>

    </div>
</asp:Content>
