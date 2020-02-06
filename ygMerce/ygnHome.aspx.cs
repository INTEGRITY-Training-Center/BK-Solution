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
    public partial class ygnHome : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            BrandController brControl = new BrandController();
            List<brandinfoinfo> lsBran = new List<brandinfoinfo>();
            lsBran = brControl.SelectAllBrandInfo();
            GridView1.DataSource = lsBran;
            GridView1.DataBind();
        }
    }
}