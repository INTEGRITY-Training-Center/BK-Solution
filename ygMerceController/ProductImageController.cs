using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
   public class ProductImageController
    {
        product_imageinfo piinfo;
        product_imageDao piDao=new product_imageDao ();
        List<product_imageinfo> lstProduct_images;

        public List<product_imageinfo> SelectAllproduct_imageinfo()
        {
            lstProduct_images = new List<product_imageinfo>();
            lstProduct_images = piDao.Selectallproduct_imagecs();
            return lstProduct_images;
        }

        public void InsertProductImage(product_imageinfo prinfo)
        {
            piDao = new product_imageDao();
            piDao.InsertProductImage(prinfo);
        }

        public void UpdateProductImage(product_imageinfo prinfo)
        {
            piDao = new product_imageDao();
            piDao.UpdateProductImagebyProductId(prinfo);
        }
        public void DelectProductImage(product_imageinfo prinfo)
        {
            piDao = new product_imageDao();
            piDao.DelectProductImagebyProductimgId(prinfo);
        }
        public List<product_imageinfo> SelectProductImageByProductID (string productId)
        {
            piDao = new product_imageDao();

            return piDao.SelectByID(productId);
        }
    }
}
