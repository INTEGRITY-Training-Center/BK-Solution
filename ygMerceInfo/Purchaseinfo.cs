using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
   public class Purchaseinfo
    {
        public string PurchaseID { get; set; }
        public string ProductID { get; set; }
        public string Quantity { get; set; }
        public string Supplier { get; set; }
        public DateTime Purchase_Order_Date { get; set; }
        public DateTime Last_Order_Date { get; set; }
    }
}
