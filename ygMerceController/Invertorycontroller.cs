using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class Invertorycontroller
    {
        
        inventorydao invendao = new inventorydao();
        List<Inventoryinfo> listinventory = new List<Inventoryinfo>();
        public List<Inventoryinfo> selectallinventory()
        {
            listinventory = new List<Inventoryinfo>();
            listinventory = invendao.selectallInventoryinfo();
            return listinventory;
        }
        public string InsertInventory(Inventoryinfo invenInfo)
        {
            invendao = new inventorydao();
           return invendao.insertinventory(invenInfo);
        }
        public void UpdateInventory(Inventoryinfo invenInfo)
        {
            invendao = new inventorydao();
            invendao.UpdateInventoryByInventoryID(invenInfo);
        }
        public void DeleteInventory(Inventoryinfo invenInfo)
        {
            invendao = new inventorydao();
            invendao.DeleteInventoryByInventoryID(invenInfo);
        }


    }
}
