using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
    public class Inventoryinfo
    {
        public string InventoryID { get; set; }
        public string ProductID { get; set; }
        public int UnitInStock { get; set; }

        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
