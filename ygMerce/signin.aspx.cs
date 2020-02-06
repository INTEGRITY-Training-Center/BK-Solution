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
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void BtnSignIn_Click(object sender, EventArgs e)
        {
            BKCustomerController bcon = new BKCustomerController();
            BKCustomerInfo bin = new BKCustomerInfo();
            bin.Contact = txtmobile.Text.Trim();
            bin.CustomerPassword = txtPassword.Text.Trim();
            int ret = bcon.LoginStatus(bin);
            if (ret > 0)
            {
                if (customCheck.Checked)
                {
                   
                }
                Response.Redirect("tstProduct.aspx");
            }
            else {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", @"alert('Mobile No (or) Password is incorrect!')", true);

            }



        }
    }
}