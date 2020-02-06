using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;


namespace ygMerceDAO
{
    public class invoice_historydao
    {
        public List<invoice_historyinfo> selectallinvoice_historyinfo()
        {
            try
            {
                List<invoice_historyinfo> lstihinfo = new List<invoice_historyinfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    invoice_historyinfo ihinfo;
                    var a = (from o in db.Invoice_Histories select o).ToList();
                    foreach (var obj in a)
                    {
                        ihinfo = new invoice_historyinfo();
                        ihinfo.InvoiceID = obj.InvoiceID;
                        ihinfo.No = obj.No;
                        ihinfo.ProductName = obj.ProductName;
                        ihinfo.Qty = obj.Qty;
                        ihinfo.Price = obj.Price;
                        ihinfo.Amount = obj.Amount;
                        lstihinfo.Add(ihinfo);
                    }
                    return lstihinfo;
                }
            }
            catch (Exception ex)
            {
                return new List<invoice_historyinfo>();
            }
        }

        public void InsertInvoice_History(invoice_historyinfo inhfo)
        {

            using (RMSDataContext db = new RMSDataContext())
            {
                Invoice_History inv = new Invoice_History();
                
                inv.InvoiceID = inhfo.InvoiceID;
                inv.No = inhfo.No;
                inv.ProductName = inhfo.ProductName;
                inv.Qty = inhfo.Qty;
                inv.Price = inhfo.Price;
                inv.Amount = inhfo.Amount;
                db.Invoice_Histories.InsertOnSubmit(inv);
                db.SubmitChanges();
            }
        }
        public void updateinvoiceupdateid(invoice_historyinfo invoicehisupdae)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.Invoice_Histories where o.InvoiceID == invoicehisupdae.InvoiceID select o).First();

                    obj.InvoiceID = invoicehisupdae.InvoiceID;
                    obj.Price = invoicehisupdae.Price;
                    obj.ProductName = invoicehisupdae.ProductName;
                    obj.Qty = invoicehisupdae.Qty;
                    obj.No = invoicehisupdae.No;
                    obj.Amount = invoicehisupdae.Amount;
                    db.SubmitChanges();


                }

            }
           catch(Exception ex)
            {
                invoice_historyinfo invoice_his = new invoice_historyinfo();

            }
            
            
        }
        public void deletinvoicehistorydeleteid(invoice_historyinfo deleid)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.Invoice_Histories where o.InvoiceID == deleid.InvoiceID select o).First();
                    db.Invoice_Histories.DeleteOnSubmit(obj);
                    db.SubmitChanges();

                }
            }
            catch(Exception ex)
            {
                invoice_historyinfo invoice_his = new invoice_historyinfo();

            }
        }
    }
}
