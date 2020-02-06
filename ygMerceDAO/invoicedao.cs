using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class invoicedao
    {
        public List<invoice_info> selectallInvoiceinfo()
        {
            try
            {
                List<invoice_info> lstininfo = new List<invoice_info>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    invoice_info ininfo;
                    var a = (from o in db.Invoices select o).ToList();
                    foreach (var obj in a)
                    {
                        ininfo = new invoice_info();
                        ininfo.InvoiceID = obj.InvoiceID;
                        ininfo.No = obj.No;
                        ininfo.ProductName = obj.ProductName;
                        ininfo.Qty = obj.Qty;
                        ininfo.Price = obj.Price;
                        ininfo.Amount = obj.Amount;
                        lstininfo.Add(ininfo);
                    }
                    return lstininfo;

                }
            }
            catch (Exception ex)
            {
                return new List<invoice_info>();
            }
        }
        public invoice_info selectinvoiceid(invoice_info invoiceid)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    invoice_info invoicinfo;
                    var obj = (from o in db.Invoices where o.InvoiceID == invoiceid.InvoiceID select o).First();
                    invoicinfo = new invoice_info();
                    invoicinfo.InvoiceID = obj.InvoiceID;
                    invoicinfo.No = obj.No;
                    invoicinfo.Price = obj.Price;
                    invoicinfo.ProductName = obj.ProductName;
                    invoicinfo.Amount = obj.Amount;
                    invoicinfo.Qty = obj.Qty;
                    return invoiceid;









                }
            }
            catch (Exception ex)
            {
                return new invoice_info();

            }

        }

        public void insertinvoice(invoice_info invoiceinsert)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                Invoice tbl = new Invoice();
                Guid a = Guid.NewGuid();
                tbl.Amount = invoiceinsert.Amount;
                tbl.InvoiceID = a.ToString();
                tbl.No = invoiceinsert.No;
                tbl.Price = invoiceinsert.Price;
                tbl.ProductName = invoiceinsert.ProductName;
                tbl.Qty = invoiceinsert.Qty;
                db.Invoices.InsertOnSubmit(tbl);
                db.SubmitChanges();

            }
        }
        public void invoiceupdateupdateid(invoice_info invoiceupdate)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.Invoices where o.InvoiceID == invoiceupdate.InvoiceID select o).First();

                    obj.InvoiceID = invoiceupdate.InvoiceID;
                    obj.No = invoiceupdate.No;
                    obj.Price = invoiceupdate.No;
                    obj.ProductName = invoiceupdate.ProductName;
                    obj.Qty = invoiceupdate.Qty;
                    obj.Amount = invoiceupdate.Amount;
                    db.SubmitChanges();



                }
            }
            catch (Exception ex)
            {
                invoice_info invoice = new invoice_info();
            }



        }
        public void deleteinvoicedeleteid(invoice_info deleteinvoiceid)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.Invoices where o.InvoiceID == deleteinvoiceid.InvoiceID select o).First();
                    db.Invoices.DeleteOnSubmit(obj);
                    db.SubmitChanges();


                }
            }
            catch (Exception ex)
            {
                invoice_info invoice = new invoice_info();
            }
        }

    }
}
