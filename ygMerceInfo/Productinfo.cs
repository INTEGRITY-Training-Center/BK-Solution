using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
    public class Productinfo
    {

        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Product_description { get; set; }
        public string SupplierID { get; set; }

        public string CategoryID { get; set; }
       
        public string BrandID { get; set; }
        public string UMID { get; set; }

        public string Color { get; set; }
        public string Size { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime Manufacture_date { get; set; }
        public DateTime Product_Expired_date { get; set; }
        public string Manufacture_Country { get; set; }
        public DateTime Expired_date { get; set; }
        public DateTime Inserted_date { get; set; }


    }
}
