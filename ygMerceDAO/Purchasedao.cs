using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
   public class Purchasedao
    {
       public List<Purchaseinfo> SelectallPurchaseinfo()
       {
           try
           {
               List<Purchaseinfo> lstpiinfo = new List<Purchaseinfo>();
               using (RMSDataContext db = new RMSDataContext())
               {
                   Purchaseinfo piinfo;
                   var a = (from o in db.Purchases select o).ToList();
                   foreach (var obj in a)
                   {
                       piinfo = new Purchaseinfo();
                       piinfo.PurchaseID = obj.PurchaseID;
                       piinfo.ProductID = obj.ProductID;
                       piinfo.Quantity = obj.Quantity;
                       piinfo.Supplier = obj.Supplier;
                       piinfo.Purchase_Order_Date = obj.Purchase_Order_Date;
                       piinfo.Last_Order_Date = obj.Last_Order_Date;
                       lstpiinfo.Add(piinfo);



                   }
                   return lstpiinfo;
               }
           }


           catch (Exception ex)
           {

               return new List<Purchaseinfo>();
           }
       }

        public void InsertPurchase(Purchaseinfo pinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                Purchase tbl = new Purchase();
                tbl.ProductID = pinfo.ProductID;
                tbl.Last_Order_Date = pinfo.Last_Order_Date;
                tbl.PurchaseID = pinfo.PurchaseID;
                tbl.Purchase_Order_Date = pinfo.Purchase_Order_Date;
                tbl.Quantity = pinfo.Quantity;
                tbl.Supplier = pinfo.Supplier;
                db.Purchases.InsertOnSubmit(tbl);
                db.SubmitChanges();
            }
        }

        public void UpdatePurchasebyPurchesId(Purchaseinfo puinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var pu = (from p in db.Purchases where p.PurchaseID == puinfo.PurchaseID select p).First();

                    pu.PurchaseID = puinfo.PurchaseID;
                    pu.Last_Order_Date = puinfo.Last_Order_Date;
                    pu.ProductID = puinfo.ProductID;
                    pu.Purchase_Order_Date = puinfo.Purchase_Order_Date;
                    pu.Quantity = puinfo.Quantity;
                    pu.Supplier = puinfo.Supplier;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Purchaseinfo p = new Purchaseinfo();
            }
        }
        public void DelectPurchaseByPurchesId(Purchaseinfo puinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var pu = (from p in db.Purchases where p.PurchaseID == puinfo.PurchaseID select p).First();


                    db.Purchases.DeleteOnSubmit(pu);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Purchaseinfo p = new Purchaseinfo();
            }

        }
    }
}
