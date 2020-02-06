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
    public partial class CellPriceForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }
        
        public void gridviewcall()
        {
            Cell_PriceController ceController = new Cell_PriceController();
            List<Cell_Priceinfoinfo> lsCell = new List<Cell_Priceinfoinfo>();
            lsCell = ceController.SelectAllCellPrice();
            gVCell_Price.DataSource=lsCell ;
            gVCell_Price.DataBind();
        }
        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Cell_Priceinfoinfo cinfo = new Cell_Priceinfoinfo();
            cinfo.Cell_Price1 =decimal.Parse( txtCell_Price1.Text);
            cinfo.Cell_Price2 = decimal.Parse(txtCell_Price2.Text);
            cinfo.Product_id = txtProduct_ID.Text;
            cinfo.Insert_Date = Convert.ToDateTime(txtInsertDate.Text);
            cinfo.Update_Date = Convert.ToDateTime(txtUpdateDate.Text);
            cinfo.UMID =txtUn_M_ID.Text;
            Cell_PriceController cController = new Cell_PriceController();
            cController.InsertCell_Price(cinfo);
            gridviewcall();
        }
    }
}