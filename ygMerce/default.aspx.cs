using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceInfo;
using ygMerceController;

namespace ygMerce
{
    public partial class _default : System.Web.UI.Page
    {
        Productinfo pinfo = new Productinfo();
        ProductController pcon = new ProductController();
        List<Productinfo> plst = new List<Productinfo>();
        CategoryController category_con = new CategoryController();
        List<Categoryinfo> categoryinfo_lst = new List<Categoryinfo>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categoryinfo_lst = category_con.SelectAllCategoryInfo();
                ddlCategories.DataSource = categoryinfo_lst;
                ddlCategories.DataBind();
                ddlCategories.Items.Insert(0, new ListItem(" Select Brand ", ""));

                plst = pcon.SelectAllProductinfo();
                rptMainList.DataSource = plst;
                rptMainList.DataBind();
            }
            
            
        }


        protected string listingImage(Productinfo info)
        {
          return "<img class='postedimage'  src='" + "Controller/productImgHandler.ashx?ProIMID=" + info.ProductID + "' />";
        }

        protected void ddlCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            plst = pcon.SelectProductsByCategoryId(ddlCategories.SelectedItem.Value);
            rptMainList.DataSource = plst;
            rptMainList.DataBind();
        }

        //protected string listingInfo(Productinfo info)
        //{
        //    return "<img class='postedimage'  src='" + "Controller/productImgHandler.ashx?ProIMID=" + info.ProductID + "' />";
        //}
    }
}