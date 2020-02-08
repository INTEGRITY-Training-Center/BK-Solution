using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
    public class BK_ProductInfo
    {
        public string BK_ProductID { get; set; }
        public string BK_ProductName { get; set; }

        public decimal BK_Price { get; set; }

        public string UMID { get; set; }

        public string CategoryID { get; set; }

        public DateTime InsertedDate { get; set; }

        public DateTime UpdatedDate { get; set; }


    }
}
