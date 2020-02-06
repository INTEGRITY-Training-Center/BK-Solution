using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class Cell_PriceDAO
    {
        Cell_Priceinfoinfo cpinfo = new Cell_Priceinfoinfo();

        public List<Cell_Priceinfoinfo> SelectAllCellPrice()
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    List<Cell_Priceinfoinfo> lcp = new List<Cell_Priceinfoinfo>();
                    {
                        Cell_Priceinfoinfo cppinfo;
                        var cp = (from cpp in db.Cell_Prices select cpp).ToList();

                        foreach (var obj in cp)
                        {
                            cppinfo = new Cell_Priceinfoinfo();
                            cppinfo.id = obj.id;
                            cppinfo.Product_id = obj.Product_id;
                            cppinfo.Cell_Price1 = obj.Cell_Price1;
                            cppinfo.Cell_Price2 = obj.Cell_Price2;
                            cppinfo.UMID = obj.UMID;
                            cppinfo.Insert_Date = obj.Insert_Date;
                            cppinfo.Update_Date = obj.Update_Date;
                        }

                        return lcp;
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<Cell_Priceinfoinfo>();
            }
        }

        public void InsertCellPrice(Cell_Priceinfoinfo cp)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    Cell_Price tbl = new Cell_Price();
                    Guid sellID = Guid.NewGuid();
                    tbl.id = sellID.ToString();
                    tbl.Product_id = cp.Product_id;
                    tbl.Cell_Price1 = cp.Cell_Price1;
                    tbl.Cell_Price2 = cp.Cell_Price2;
                    tbl.UMID = cp.UMID;
                    tbl.Insert_Date = DateTime.Now;
                    tbl.Update_Date = DateTime.Now;
                    db.Cell_Prices.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Cell_Price c = new Cell_Price();
            }
        }
        public void UpdateCell_PriceByID(Cell_Priceinfoinfo cinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                var obj = (from a in db.Cell_Prices where a.id == cinfo.id select a).First();
                obj.id = cinfo.id;
                obj.Product_id = cinfo.Product_id;
                obj.Cell_Price1 = cinfo.Cell_Price1;
                obj.Cell_Price2 = cinfo.Cell_Price2;
                obj.UMID = cinfo.UMID;
                obj.Update_Date = cinfo.Update_Date;
                db.SubmitChanges();
            }
        }
        public void DeleteCell_PriceByID(Cell_Priceinfoinfo cinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Cell_Prices where a.id == cinfo.id select a).First();
                    db.Cell_Prices.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Cell_Price c = new Cell_Price();
            }

        }
        }
    }
