using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class BKCustomerController
    {
        BKCustomerDAO cusdao = new BKCustomerDAO();
        List<BKCustomerInfo> listcustomer = new List<BKCustomerInfo>();
        public List<BKCustomerInfo> selectallBKCustomerInfo()
        {
            listcustomer = new List<BKCustomerInfo>();
            listcustomer = cusdao.selectallBKCustomerInfo();
            return listcustomer;
        }

        public int selectBKCustomerInfoByMobile(string mb)
        {
            
          
            return cusdao.selectallBKCustomerInfoByMobile(mb); 
        }
        public string InsertCustomer(BKCustomerInfo custInfo)
        {
           return cusdao.insert_customer(custInfo);
        }
        public void UpdateCustomer(BKCustomerInfo custInfo)
        {
            cusdao.UpdateCustomerByCustomerID(custInfo);
        }
        public void DeleteCustomer(BKCustomerInfo custInfo)
        {
            cusdao.DeleteCustomerByCustomerID(custInfo);
        }

        public int LoginStatus(BKCustomerInfo custInfo)
        {
           return  cusdao.Login(custInfo.Contact,custInfo.CustomerPassword);
        }
    }
}
