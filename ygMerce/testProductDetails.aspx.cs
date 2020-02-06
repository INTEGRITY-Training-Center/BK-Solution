using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceInfo;
using ygMerceController;
using System.Web.ModelBinding;

namespace ygMerce
{
    public partial class testProductDetails : System.Web.UI.Page
    {
        ProductController productCtlr = new ProductController();
        public Productinfo productInfo = new Productinfo();

        List<Productinfo> shopItemsLst;
        protected void Page_Load(object sender, EventArgs e)
        {
            string productId = Request.QueryString["ProductID"];
            productInfo = productCtlr.SelectByID(productId);

            if (!Page.IsPostBack)
            {
                ltProductName.Text = productInfo.ProductName.ToString();
                ltAboutProduct.Text = productInfo.Product_description.ToString();

                rptMainList.DataSource = SelectProductImagebyProductId(productId);
                rptMainList.DataBind();

                shopItemsLst = new List<Productinfo>();
            }


        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public ygMerceInfo.Productinfo ProductDetail_GetItem([QueryString("ProductID")] string id)
        {
            ProductController pCon = new ProductController();
            Productinfo query = pCon.SelectByID(id);
            return query;
        }

        public string ProductImage(string ProductID)
        {
            return "<img id='big-image' class='showImage'  src='" + "Controller/productImgHandler.ashx?ProIMID=" + ProductID + "' />";
        }

        public string listingImage(product_imageinfo info)
        {
            return "<img onclick='ChangeImage(this)' class='slideImage'  src='" + "Controller/productImgHandler1.ashx?ProIMID=" + info.Product_imageID + "' />";
        }

        public List<product_imageinfo> SelectProductImagebyProductId(string productId)
        {
            ProductImageController productImageCon = new ProductImageController();
            List<product_imageinfo> query;

            return query = productImageCon.SelectProductImageByProductID(productId);

        }

        protected void BindData(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "desc":
                    string desc = productInfo.Product_description.ToString();
                    ltAboutProduct.Text = desc;
                    break;
                case "price":
                    string price = productInfo.UnitPrice.ToString("C");
                    ltAboutProduct.Text = price;
                    break;
                case "others":
                    string others = string.Format(@"Name : {0}<br> Country Made : {1}<br> Avaiable Color: {2}<br> Size : 
                                                    {3}<br> Expired Date : {4}"
                        , productInfo.ProductName, productInfo.Manufacture_Country
                        , productInfo.Color, productInfo.Size, productInfo.Expired_date.ToShortDateString());
                    ltAboutProduct.Text = others;
                    break;
                default:
                    ltAboutProduct.Text = "There is no data for this product.";
                    break;
            }
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (Session["myShopItems"] != null)
            {
                shopItemsLst = (List<Productinfo>)Session["myShopItems"];

                var check = shopItemsLst.FirstOrDefault(s => s.ProductID.Equals(productInfo.ProductID));
                if (check != null)
                {
                    shopItemsLst.FirstOrDefault(s => s.ProductID == check.ProductID).UMID += 1;
                }
                else
                {
                    shopItemsLst.Add(productInfo);
                }
            }

            Session["myShopItems"] = shopItemsLst;
            Response.Write(Session["myShopItems"]);
        }

    }
}