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
    public partial class CityForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }
        protected void btnSaveCity_Click(object sender, EventArgs e)
        {
            Cityinfo cinfo = new Cityinfo();
            cinfo.City_Description= txtCity_Description.Text;
            cinfo.City_Name = txtCity_Name.Text;
            cinfo.DivisionID= txtCity_Description.Text;
            CityController cController = new CityController();
            cController.InsertCity(cinfo);
            gridviewcall();
        }

        public void gridviewcall()
        {
            Cell_PriceController ceController = new Cell_PriceController();
            List<Cell_Priceinfoinfo> lsCell = new List<Cell_Priceinfoinfo>();
            lsCell = ceController.SelectAllCellPrice();
            gVCity_form.DataSource = lsCell;
            gVCity_form.DataBind();
        }
    }
}