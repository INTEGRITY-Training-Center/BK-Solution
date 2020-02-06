using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
    public class Customerinfo
    {
        public string CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string Name { get; set; }
        public string TownshipID { get; set; }
        public int Contact { get; set; }
        public string address { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
