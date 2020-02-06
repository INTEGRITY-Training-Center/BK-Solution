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
    public partial class Invoice_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grideviewcall();
           
        }

        protected void btnsaveinvoice_Click(object sender, EventArgs e)
        {
            invoice_info invoiin = new invoice_info();
            invoice_historyinfo invoicehis = new invoice_historyinfo();
            InvoiceController invcon = new InvoiceController();
            Invoice_HistoryController invoicehiscon=new Invoice_HistoryController();
            invoiin.No = txtnoinvoice.Text;
            invoiin.Price = txtpriceinvoice.Text;
            invoiin.ProductName = txtnameinvoice.Text;
            invoiin.Qty = txtqtyinvoice.Text;
            invoiin.Amount = txtamountinvoice.Text;
            invcon.insertinvoice(invoiin);

           invoicehis.No = txtnoinvoice.Text;
           invoicehis.Price = txtpriceinvoice.Text;
           invoicehis.ProductName = txtnameinvoice.Text;
           invoicehis.Qty = txtqtyinvoice.Text;
           invoicehis.Amount = txtamountinvoice.Text;

           invoicehiscon.invoicehisinsert(invoicehis);

            
         

            grideviewcall();
        }
        public void grideviewcall()
        {
            InvoiceController invoicecon = new InvoiceController();
            List<invoice_info> lisinvoice = new List<invoice_info>();
            lisinvoice = invoicecon.selectallInvoiceinfo();
            GridView1.DataSource = lisinvoice;
            GridView1.DataBind();

        }
    }
}