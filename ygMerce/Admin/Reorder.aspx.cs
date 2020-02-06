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
    public partial class Reorder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }


        protected void btnSaveReorder_Click(object sender, EventArgs e)
        {
            ReorderInfo Reoinfo = new ReorderInfo();
            Reoinfo.ReorderID = txtProductID.Text;
            Reoinfo.InventoryID = txtInventoryID.Text;
            Reoinfo.ReorderUnit = txtReorderUnit.Text;
            //
            ReorderController Reocontroller = new ReorderController();
            Reocontroller.InsertReorder(Reoinfo);
            gridviewcall();


        }


        public void gridviewcall()
        {

            RegionController RegionControl = new RegionController();
            List<Regioninfo> lsRegion = new List<Regioninfo>();
            lsRegion = RegionControl.SelectAllRegioninfo();
            GridView1.DataSource = lsRegion;
            GridView1.DataBind();

        }

    }
}