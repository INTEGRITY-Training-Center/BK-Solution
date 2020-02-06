using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;


namespace ygMerceController
{
    public class SupplierController
    {
        SupplierInfo suppInfo = new SupplierInfo();
        SupplierDAO suppDao = new SupplierDAO();

        public List<SupplierInfo> SelectAllSupplierInfo()
        {
            List<SupplierInfo> lstSupplier = new List<SupplierInfo>();
            lstSupplier = suppDao.SelectAllSupplierInfo();
            return lstSupplier;


        }
        public void InsertSupplier(SupplierInfo SuppInfo)
        {
            suppDao.InsertSupplierInfo(SuppInfo);
        }

        public void UpdateSupplier(SupplierInfo SuppInfo)
        {
            suppDao.UpdateSupplierBySupplierID(SuppInfo);
        }

        public void DeleteSupplier(SupplierInfo SuppInfo)
        {
            suppDao.DeleteSupplierBySupplierID(SuppInfo);
        }
    }
}
