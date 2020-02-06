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
    public partial class Invoicehis_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            Invoice_HistoryController invoicehisdao = new Invoice_HistoryController();
            List<invoice_historyinfo> listinvoice = new List<invoice_historyinfo>();
            listinvoice = invoicehisdao.selectallinvoice_historyinfo();
            GridView1.DataSource = listinvoice;
            GridView1.DataBind();

        }
    }
}