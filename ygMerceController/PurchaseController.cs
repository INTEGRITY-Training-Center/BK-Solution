using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class PurchaseController
    {
        Purchaseinfo puinfo;
        Purchasedao puDao;
        List<Purchaseinfo> lstPurchase;
        public List<Purchaseinfo> SelectAllPurchaseinfo()
        {
            lstPurchase = new List<Purchaseinfo>();
            lstPurchase = puDao.SelectallPurchaseinfo();
            return lstPurchase;
        }
        public void InsertPurches(Purchaseinfo puinfo)
        {
            puDao.InsertPurchase(puinfo);
        }
        public void UpdatePurches(Purchaseinfo puinfo)
        {
            puDao.UpdatePurchasebyPurchesId(puinfo);
        }
        public void DelectPurches(Purchaseinfo puinfo)
        {
            puDao.DelectPurchaseByPurchesId(puinfo);
        }
    }

}
