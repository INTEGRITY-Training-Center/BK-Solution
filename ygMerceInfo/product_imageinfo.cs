using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
    public class product_imageinfo
    {
        public string Product_imageID { get; set;  }
        public byte[] Images { get; set; }

        public bool MainPic { get; set; }
        public string ProductID { get; set; }


    }
}
