using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
   public class Cell_Price_HistoryDAO
    {
       public List<Cell_Price_Historyinfo> SelectAllCellPriceHistoryinfo()
       {
           try
           {
               using (RMSDataContext db = new RMSDataContext())
               {
                   List<Cell_Price_Historyinfo> lstcph = new List<Cell_Price_Historyinfo>();
                   {
                       Cell_Price_Historyinfo cphinfo;

                       var cp = (from cphi in db.Cell_Price_Histories select cphi).ToList();

                       foreach (var obj in cp)
                       {
                           cphinfo = new Cell_Price_Historyinfo();
                           cphinfo.id = obj.id;
                           cphinfo.Product_id = obj.Product_id;
                           cphinfo.Cell_Price1 = obj.Cell_Price1;
                           cphinfo.Cell_Price2 = obj.Cell_Price2;
                           cphinfo.Un_Mid = obj.Un_Mid;
                       }
                       return lstcph;
                   }
               }
           }
           catch (Exception ex)
           {
               return new List<Cell_Price_Historyinfo>();
           }
       }

       public void InsertCellPriceHistory(Cell_Price_Historyinfo cphInfo)
       {
           try
           {
               using (RMSDataContext db = new RMSDataContext())
               {
                   Cell_Price_History tbl = new Cell_Price_History();
                   tbl.id = cphInfo.id;
                   tbl.Cell_Price1 = cphInfo.Cell_Price1;
                   tbl.Cell_Price2 = cphInfo.Cell_Price2;
                   tbl.Un_Mid = cphInfo.Un_Mid;

                   db.Cell_Price_Histories.InsertOnSubmit(tbl);
                   db.SubmitChanges();
               }
           }
           catch (Exception ex)
           {
               Cell_Price_History cph = new Cell_Price_History();
           }
       }

        public void UpdateCell_Price_HistoryByID(Cell_Price_Historyinfo cinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Cell_Price_Histories where a.id == cinfo.id select a).First();
                    obj.id = cinfo.id;
                    obj.Cell_Price1 = cinfo.Cell_Price1;
                    obj.Cell_Price2 = cinfo.Cell_Price2;
                    obj.Un_Mid = cinfo.Un_Mid;
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                Cell_Price_History cph = new Cell_Price_History();
            }
        }

        public void DeleteCell_Price_HistoryByID(Cell_Price_Historyinfo cinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Cell_Price_Histories where a.id == cinfo.id select a).First();
                    db.Cell_Price_Histories.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Cell_Price_History cph = new Cell_Price_History();
            }
        }
        }
}
