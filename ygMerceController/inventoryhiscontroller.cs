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
       inventory_history_info inventoryhis;
       Inventoryhis_dao invenhisdao = new Inventoryhis_dao();
       List<inventory_history_info> listinventory = new List<inventory_history_info>();
        public List<inventory_history_info>selectallinventory_history()
       {
           listinventory = new List<inventory_history_info>();
           listinventory = invenhisdao.selectalliinventoryhis ();
           return listinventory;
       }
      

    }
}
