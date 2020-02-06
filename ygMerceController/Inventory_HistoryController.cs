using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class inventoryhiscontroller
    {

        Inventoryhis_dao invenhisdao = new Inventoryhis_dao();
        List<inventory_history_info> listinventory;
        public List<inventory_history_info> selectallinventory_history()
        {
            listinventory = new List<inventory_history_info>();
            listinventory = invenhisdao.selectalliinventoryhis();
            return listinventory;
        }
        public void InsertInventory_History(inventory_history_info invenInfo)
        {
            invenhisdao.InsertInventoryHistory(invenInfo);
        }
        public void UpdateInventory_History(inventory_history_info invenInfo)
        {
            invenhisdao.UpdateInventoryHistoryByID(invenInfo);
        }
        public void DeleteInventory_History(inventory_history_info invenInfo)
        {
            invenhisdao.DeleteInventoryHistoryByID(invenInfo);
        }


    }
}
