using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
   public class Invoice_HistoryController
    {
       Inventoryinfo invinfo;
       inventorydao invd = new inventorydao();

       List<Inventoryinfo> linv = new List<Inventoryinfo>();

       public List<Inventoryinfo> selectallinvoice_historyinfo()
       {
           linv = invd.selectallInventoryinfo();
           return linv;
       }
  
    }
}
