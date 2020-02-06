using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;


namespace ygMerceController
{
  public  class Customercontroller
    {

        CustomerDao cusdao = new CustomerDao();
        List<Customerinfo> listcustomer = new List<Customerinfo>();
      public List<Customerinfo>selectallcustomerinfo()
        {
            listcustomer = new List<Customerinfo>();
            listcustomer = cusdao.selectallcustomerinfo();
            return listcustomer;
        }
        public void InsertCustomer(Customerinfo custInfo)
        {
            cusdao.insert_customer(custInfo);
        }
        public void UpdateCustomer(Customerinfo custInfo)
        {
            cusdao.UpdateCustomerByCustomerID(custInfo);
        }
        public void DeleteCustomer(Customerinfo custInfo)
        {
            cusdao.DeleteCustomerByCustomerID(custInfo);
        }

    }
}
