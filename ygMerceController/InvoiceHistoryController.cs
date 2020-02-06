using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class Invoice_HistoryController
    {
        invoice_historyinfo invinfo;
        invoice_historydao invd = new invoice_historydao ();

        List<invoice_historyinfo> linv ;

        public List<invoice_historyinfo> selectallinvoice_historyinfo()
        {
            linv = new List<invoice_historyinfo>();
            linv = invd.selectallinvoice_historyinfo();
            return linv;
        }
        public void invoicehisinsert(invoice_historyinfo insertinvoice )
        {
            invd.InsertInvoice_History(insertinvoice);

          
        }
        public void invoicehisupdate(invoice_historyinfo updatinvoice)
        {
            invd.updateinvoiceupdateid(updatinvoice);

        }
        public void invoicehisdelete(invoice_historyinfo deleteinvoicehis)
        {
            invd.deletinvoicehistorydeleteid(deleteinvoicehis);

        }
    }
}
