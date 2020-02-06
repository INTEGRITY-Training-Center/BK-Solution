using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    class Product_imagesController
    {
       product_imageinfo piinfo;
        product_imagesdao piDao;
        List<product_imageinfo> lstProduct_images;

        public List<product_imageinfo> SelectAllproduct_imageinfo()
        {
            lstProduct_images = new List<product_imageinfo>();
            lstProduct_images = piDao.Selectallproduct_imagecs();
            return lstProduct_images;
                }
    }
}
