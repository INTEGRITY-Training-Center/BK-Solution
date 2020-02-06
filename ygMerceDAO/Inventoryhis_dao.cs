using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;


namespace ygMerceDAO
{
    public class Inventoryhis_dao
    {
        public List<inventory_history_info> selectalliinventoryhis()
        {
            try
            {

                List<inventory_history_info> listinventoryhis = new List<inventory_history_info>();
                {
                    using (RMSDataContext db = new RMSDataContext())
                    {
                        inventory_history_info inventoryhis;
                        var a = (from o in db.inventory_histories select o).ToList();
                        foreach (var obj in a)
                        {
                            inventoryhis = new inventory_history_info();
                            inventoryhis.InventoryID = obj.InventoryID;
                            inventoryhis.ProductID = obj.ProductID;
                            inventoryhis.Product_quantity = obj.Product_quantity;
                            inventoryhis.Inserted_date =DateTime.Parse( obj.Inserted_date);
                            listinventoryhis.Add(inventoryhis);

                        }
                        return listinventoryhis;


                    }

                }
            }
            catch(Exception ex)
            {
                return new List<inventory_history_info>();

            }
        }

        public void InsertInventoryHistory(inventory_history_info invenHis)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    inventory_history tbl = new inventory_history();
                    tbl.ProductID = invenHis.ProductID;
                    tbl.Product_quantity = invenHis.Product_quantity;
                    //tbl.Inserted_date = DateTime.Now;

                    db.inventory_histories.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                inventory_history inven = new inventory_history();
            }
        }
        public void UpdateInventoryHistoryByID(inventory_history_info inven_hisinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from invenHis in db.inventory_histories 
                               where invenHis.InventoryID == inven_hisinfo.InventoryID 
                               select invenHis).First();
                    obj.ProductID = inven_hisinfo.ProductID;
                    obj.Product_quantity = inven_hisinfo.Product_quantity;

                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                inventory_history invenHis = new inventory_history();
            }
        }
        public void DeleteInventoryHistoryByID(inventory_history_info inven_hisinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from inven_his in db.inventory_histories
                               where inven_his.InventoryID == inven_hisinfo.InventoryID
                               select inven_his).First();

                    db.inventory_histories.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                inventory_history i = new inventory_history();
            }
        }
    }
}
