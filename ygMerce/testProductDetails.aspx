<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="testProductDetails.aspx.cs" Inherits="ygMerce.testProductDetails" %>

<%@ Import Namespace="ygMerceInfo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .showImage {
            width: 210px;
            height: 150px;
        }
        .swap{
            display:none;
        }

        .slideImage {
            width: 30px;
            height: 30px;
            border: 1px solid blue;
        }

            .slideImage:hover {
                transition: opacity 2s cubic-bezier(.165,.84,.44,1);
                box-shadow: 0 8px 17px 0 rgba(138,57,3,.2), 0 6px 20px 0 rgba(0,0,0,.15);
                cursor: pointer;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row main-wrapper">
            <div class="col-md-4">
                <asp:FormView ID="ProductDetail" runat="server" ItemType="ygMerceInfo.Productinfo"
                    SelectMethod="ProductDetail_GetItem">
                    <ItemTemplate>
                        <%# ProductImage(Item.ProductID) %>
                    </ItemTemplate>
                </asp:FormView>
                <hr />
                <asp:Repeater ID="rptMainList" runat="server">
                    <ItemTemplate>
                        <%# listingImage((product_imageinfo)Container.DataItem) %>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
            <div class="col-md">
                <h3><asp:Literal runat="server" ID="ltProductName" /></h3>
                <asp:Button ID="btnDescription" runat="server" Text="Description" OnCommand="BindData" CommandName="desc" />
                <asp:Button ID="btnPrice" runat="server" Text="Price" OnCommand="BindData" CommandName="price" />
                <asp:Button ID="btnOthers" runat="server" Text="Other" OnCommand="BindData" CommandName="others" />
                <hr />
                <asp:Literal runat="server" ID="ltAboutProduct" />
                <hr />
                <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" />
            </div>
        </div>
    </div>




    <script>
        function ChangeImage(small_image) {
            var bigImage = document.getElementById('big-image');
            var temp = bigImage.src;

            bigImage.src = small_image.src;
            small_image.src = temp;
        }
    </script>

















    <%--<asp:FormView ID="ProductDetail" runat="server" ItemType="ygMerceInfo.Productinfo" SelectMethod="ProductDetail_GetItem">
        <ItemTemplate>

            <div class="container-fluid">
                <div class="row">
                    <h1 class="text-center"><%#:Item.ProductName %></h1>
                </div>

                <div class="row">
                    <%# ProductImage(Item.ProductID) %>
                </div>
                <br />
                <br />
                <div class="row">
                    Description: &nbsp; <%#: Item.Product_description  %>
                </div>
            </div>

        </ItemTemplate>
    </asp:FormView>--%>

    <%--<asp:Repeater ID="rptMainList" runat="server">

        <ItemTemplate>
            <div class="fix-image"></div>
                <%# listingImage((product_imageinfo)Container.DataItem) %>
            </div>
        </ItemTemplate>

    </asp:Repeater>--%>
</asp:Content>
