using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class BK_ProductController
    {
        BK_ProductDAO dao = new BK_ProductDAO();

        public List<BK_ProductInfo> SelectallBKProductinfo()
        {
            dao = new BK_ProductDAO();
            return dao.SelectallBKProductinfo();
        }

        public bool InsertBK_Product(BK_ProductInfo pinfo)
        {
            dao = new BK_ProductDAO();
            return dao.InsertBK_Product(pinfo);
        }

        public bool InsertBK_ProductByList(List<BK_ProductInfo> bklst)
        {
            dao = new BK_ProductDAO();
            return dao.InsertBK_ProductByList(bklst);
        }
    }
}
