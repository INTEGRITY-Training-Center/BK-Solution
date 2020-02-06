using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
   public class inventory_history_info
    {
       public string InventoryID { get; set; }
       public string ProductID { get; set; }
       public string Product_quantity { get; set; }

       public DateTime Inserted_date { get; set; }

    }
}
