using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceInfo;

namespace ygMerce
{
    public partial class tstCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Productinfo> myShoppingList = new List<Productinfo>();
            myShoppingList = (List<Productinfo>)Session["myShopItems"];


            gvShoppingCart.DataSource = myShoppingList;
            gvShoppingCart.DataBind();

            Response.Write(Session["myShopItems"].ToString());
        }
    }
}