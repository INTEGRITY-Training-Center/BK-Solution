using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceController;
using ygMerceInfo;

namespace ygMerce
{
    public partial class ProductHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            callprouductview();
        }

        protected void btnproducthistorysave_Click(object sender, EventArgs e)
        {
            Product_historyinfo phinfo = new Product_historyinfo();
            ProductHistoryController phcon = new ProductHistoryController();

            phinfo.ProductName = txtproductname.Text;
            phinfo.Product_image = txtproductimage.Text;
            phinfo.Product_description = txtproductdescription.Text;
            phinfo.Category = txtcatagory.Text;
            phinfo.BrandID = txtbrandid.Text;
            phinfo.BrandName = txtbrandname.Text;
            phinfo.Color = txtcolor.Text;
            phinfo.Size = txtsize.Text;
            phinfo.Purchase_price = Convert.ToDecimal(txtpruchesprice.Text);
            phinfo.Manufacture_date = Convert.ToDateTime(txtmanufacturedate.Text);
            phinfo.Product_Expired_date = Convert.ToDateTime(txtproductexpiredate.Text);
            phinfo.Manufacture_Country = txtmanufacturecountry.Text;
            phinfo.Inserted_date = Convert.ToDateTime(txtinserteddate.Text);

            phcon.InsertProductHistory(phinfo);
            callprouductview();

        }
        public void callprouductview()
        {
            ProductHistoryController pcontr = new ProductHistoryController();
            List<Product_historyinfo> lph = new List<Product_historyinfo>();
            lph = pcontr.SelectallProductinfo();
            GridView1.DataSource = lph;
            GridView1.DataBind();
        }
    }
}