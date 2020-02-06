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
    public partial class Region : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }

        protected void btnSaveRegion_Click(object sender,EventArgs e)
{
            Regioninfo Regiinfo=new Regioninfo();
          //  Regiinfo.RegionID=txtRegionID.Text;
            Regiinfo.Region_Name = txtRegionName.Text;
            Regiinfo.Region_Description = txtRegionDescription.Text;
            RegionController RegiController= new RegionController();
            RegiController.InsertRegion(Regiinfo);
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