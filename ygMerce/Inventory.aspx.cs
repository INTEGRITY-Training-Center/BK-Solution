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
    public partial class Inventory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductController productCtlr = new ProductController();
            List<Productinfo> productLst = new List<Productinfo>();
            productLst = productCtlr.SelectAllProductinfo();
            ProductData.DataSource = productLst;
            ProductData.DataBind();
            SelectAllInventory();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Invertorycontroller inventoryCtlr = new Invertorycontroller();
            Inventoryinfo inventoryInfo = new Inventoryinfo();

            inventoryInfo.ProductID = ProductData.SelectedValue;
            inventoryInfo.Product_Quantity = txtProductQtty.Text;

            inventoryCtlr.InsertInventory(inventoryInfo);

            inventoryhiscontroller invenHisCtlr = new inventoryhiscontroller();
            inventory_history_info invenHisInfo = new inventory_history_info();

            invenHisInfo.ProductID = ProductData.SelectedValue;
            invenHisInfo.Product_quantity = txtProductQtty.Text;

            invenHisCtlr.InsertInventory_History(invenHisInfo);
            SelectAllInventory();
        }
        void SelectAllInventory()
        {
            Invertorycontroller invenCtl = new Invertorycontroller();
            List<Inventoryinfo> invenLst = new List<Inventoryinfo>();
            invenLst = invenCtl.selectallinventory();

            invenGv.DataSource = invenLst;
            invenGv.DataBind();
        }
    }
}