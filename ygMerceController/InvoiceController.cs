using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class InvoiceController
    {
        invoicedao inda = new invoicedao();
        List<invoice_info> linvin;

        public List<invoice_info> selectallInvoiceinfo()
        {
            linvin = new List<invoice_info>();
            linvin = inda.selectallInvoiceinfo();
            return linvin;
        }
        public void updateinvoice(invoice_info updateinvoice)
        {
            inda.invoiceupdateupdateid(updateinvoice);
        }
        public void insertinvoice(invoice_info insertinvoice)
        {
            inda.insertinvoice(insertinvoice);
        }
        public void deleinvoicecontroller(invoice_info deleteinvoice)
        {
            inda.deleteinvoicedeleteid(deleteinvoice);
        }
    }
}
