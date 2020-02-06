using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class ProductHistoryController
    {
        Product_historyinfo pinfo;
        Product_historydao pda0 = new Product_historydao();
        List<Product_historyinfo> linfo = new List<Product_historyinfo>();

        public List<Product_historyinfo> SelectallProductinfo()
        {
            linfo = new List<Product_historyinfo>();
            linfo = pda0.SelectallProduct_historyinfo();
            return linfo;
        }
        public void InsertProductHistory(Product_historyinfo phinfo)
        {
           pda0.InsertProduct_History(phinfo);
        }
        public void UpdateProductHistory(Product_historyinfo phinfo)
        {
            pda0.product_historyupdateupdateid(phinfo);
        }
        public void DelectProductHistory(Product_historyinfo phinfo)
        {
            pda0.deleteproducthistory(phinfo);
        }
    }
}
