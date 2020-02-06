using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class inventorydao
    {
        public List<Inventoryinfo> selectallInventoryinfo()
        {
            try {
                List<Inventoryinfo> lstiinfo = new List<Inventoryinfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    Inventoryinfo iinfo;
                    var a = (from o in db.inventories select o).ToList();
                    foreach(var obj in a)
                    {
                        iinfo = new Inventoryinfo();
                        iinfo.InventoryID = obj.InventoryID;
                        iinfo.ProductID = obj.ProductID;
                        iinfo.UnitInStock = obj.UnitInStock;
                        iinfo.InsertDate = obj.Inserted_date;
                        iinfo.UpdateDate = obj.Updated_date;
                        lstiinfo.Add(iinfo);
                    }
                    return lstiinfo;
                }
            }
            catch(Exception ex)
            {
                return new List<Inventoryinfo>();
            }
       }    
        public string insertinventory(Inventoryinfo inveninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    inventory inventbl = new inventory();
                    Guid iID = Guid.NewGuid();
                    inventbl.InventoryID = iID.ToString();
                    inventbl.UnitInStock = inveninfo.UnitInStock;
                    inventbl.ProductID = inveninfo.ProductID;
                    inventbl.Inserted_date = DateTime.UtcNow.AddMinutes(390);
                    inventbl.Updated_date = DateTime.UtcNow.AddMinutes(390);
                    db.inventories.InsertOnSubmit(inventbl);
                    db.SubmitChanges();

                    return iID.ToString();
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public void UpdateInventoryByInventoryID(Inventoryinfo inveninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from inven in db.inventories 
                               where inven.InventoryID == inveninfo.InventoryID 
                               select inven).First();

                    obj.UnitInStock = inveninfo.UnitInStock;
                    obj.ProductID = inveninfo.ProductID;
                    obj.Updated_date = DateTime.Now;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                inventory inven = new inventory();
            }
        }
        public void DeleteInventoryByInventoryID(Inventoryinfo inveninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from inven in db.inventories
                               where inven.InventoryID == inveninfo.InventoryID
                               select inven).First();

                    db.inventories.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                inventory i = new inventory();
            }
        }
    }
}
