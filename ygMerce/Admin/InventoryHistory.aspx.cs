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
    public partial class InventoryHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            inventoryhiscontroller invenCtl = new inventoryhiscontroller();
            List<inventory_history_info> invenHistoryLst = new List<inventory_history_info>();
            invenHistoryLst = invenCtl.selectallinventory_history();

            InventoryHisGv.DataSource = invenHistoryLst;
            InventoryHisGv.DataBind();
        }
    }
}