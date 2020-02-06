using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class ProductController
    {
        Productinfo pinfo;
        productdao pDao;
        List<Productinfo> lstProduct;
        public List<Productinfo> SelectAllProductinfo()
        {
            pDao = new productdao();
            lstProduct = new List<Productinfo>();
            lstProduct = pDao.SelectallProductinfo();
            return lstProduct;

        }

        public string InsertProduct(Productinfo prinfo)
        {
            pDao = new productdao();
           return pDao.InsertProduct(prinfo);
        }
        public void UpdateProduct(Productinfo prinfo)
        {
            pDao = new productdao();
            pDao.UpdateProductByProductId(prinfo);
        }
        public void DelectProduct(Productinfo prinfo)
        {
            pDao = new productdao();
            pDao.DelectProductByProductId(prinfo);
        }
        public Productinfo SelectByID(string productID)
        {
            Productinfo pinfo=new Productinfo();
            productdao pDao = new productdao();
            pinfo=pDao.SelectByID(productID);

            return pinfo;
        }

        public List<Productinfo> SelectProductsByCategoryId(string categoryId)
        {
            productdao pDao = new productdao();
            return pDao.SelectProductsByCategoryId(categoryId);
        }
    }
}
