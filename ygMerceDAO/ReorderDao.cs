using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;


namespace ygMerceDAO
{
    public class ReorderDao
    {
        public List<ReorderInfo> SelectallReorderinfo()
        {
            try
            {
                List<ReorderInfo> lstinfo = new List<ReorderInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    ReorderInfo rinfo;
                    var a = (from o in db.Reorders select o).ToList();
                    foreach (var obj in a)
                    {
                        rinfo = new ReorderInfo();
                        rinfo.ReorderID = obj.ReorderID;
                        rinfo.ProductID = obj.ProductID;
                        rinfo.InventoryID = obj.InventoryID;
                        rinfo.ReorderUnit = obj.ReorderUnit;
                        lstinfo.Add(rinfo);
                    }
                    return lstinfo;
                }
            }
            catch (Exception ex)
            {
                return new List<ReorderInfo>();
            }
        }

        public void InsertReorder(ReorderInfo rinfo)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    Reorder reo = new Reorder();
                    Guid rid = Guid.NewGuid();
                    reo.ReorderID = rid.ToString();
                    reo.InventoryID = rinfo.InventoryID;
                    reo.ProductID = rinfo.ProductID;
                    reo.ReorderUnit = rinfo.ReorderUnit;

                    db.Reorders.InsertOnSubmit(reo);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex) { }
        }

        public void UpdateReorderByReorderID(ReorderInfo Reoinfo)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Reorders where a.ReorderID == Reoinfo.ReorderID select a).First();
                    {
                        obj.ReorderID = Reoinfo.ReorderID;
                        obj.ProductID = Reoinfo.ProductID;
                        obj.InventoryID = Reoinfo.InventoryID;
                        obj.ReorderUnit = Reoinfo.ReorderUnit;
                        db.SubmitChanges();
                    }

                }
            }
            catch(Exception ex){

                Reorder Reo = new Reorder();
            }


        }

         public void DeleteReorderByReorderID(ReorderInfo Reoinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Reorders where a.ReorderID == Reoinfo.ReorderID select a).First();
                    {
                        db.Reorders.DeleteOnSubmit(obj);
                        db.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                Reorder Reo = new Reorder();
            }
        }
    }
}
