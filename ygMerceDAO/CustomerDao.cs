using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
  public  class CustomerDao
    {
      public List<Customerinfo> selectallcustomerinfo()
      {
          try
          {
              List<Customerinfo> listcustomerinfo = new List<Customerinfo>();
              {
                  using (RMSDataContext db = new RMSDataContext())
                  {
                      Customerinfo customerinfo;
                      var a = (from o in db.Customers select o).ToList();
                      foreach (var obj in a)
                      {
                          customerinfo = new Customerinfo();
                          customerinfo.CustomerID = obj.CustomerID;
                          customerinfo.CustomerCode = obj.Customercode;
                          customerinfo.Name = obj.Name;
                          customerinfo.TownshipID =obj.TownshipID;
                          customerinfo.Contact = obj.Contact;
                          customerinfo.address = obj.Address;
                          customerinfo.InsertDate = obj.InsertDate;
                          customerinfo.UpdateDate = obj.UpdateDate;
                          listcustomerinfo.Add(customerinfo);

                      }
                      return listcustomerinfo;
                  }
              }
          }
          catch(Exception ex)
          {
              return new List<Customerinfo>();
          }

      }
      public void insert_customer(Customerinfo custinfo)
      {

          using(RMSDataContext db= new RMSDataContext())
          {
              Customer custbl = new Customer();
              custbl.CustomerID = custinfo.CustomerID;
              custbl.Customercode = custinfo.CustomerCode;
              custbl.Address = custinfo.address;
              custbl.Contact = custinfo.Contact;
              custbl.InsertDate = custinfo.InsertDate;
              custbl.Name = custinfo.Name;
              custbl.TownshipID = custinfo.TownshipID;
              custbl.UpdateDate = custinfo.UpdateDate;
              db.Customers.InsertOnSubmit(custbl);
              db.SubmitChanges();
          }
      }

      public void UpdateCustomerByCustomerID(Customerinfo custinfo)
      {
          try
          {
              using (RMSDataContext db = new RMSDataContext())
              {
                  var obj = (from customer in db.Customers 
                             where customer.CustomerID == custinfo.CustomerID 
                             select customer).First();

                  obj.Customercode = custinfo.CustomerCode;
                  obj.Contact = custinfo.Contact;
                  obj.Address = custinfo.address;
                  obj.Name = custinfo.Name;
                  obj.TownshipID = custinfo.TownshipID;
                  obj.UpdateDate = DateTime.Now;

                  db.SubmitChanges();
              }
          }
          catch (Exception ex)
          {
              Customer cust = new Customer();
          }
      }
      public void DeleteCustomerByCustomerID(Customerinfo custinfo)
      {
          try
          {
              using (RMSDataContext db = new RMSDataContext())
              {
                  var obj = (from cust in db.Customers 
                             where cust.CustomerID == custinfo.CustomerID 
                             select cust).First();

                  db.Customers.DeleteOnSubmit(obj);
                  db.SubmitChanges();
              }
          }
          catch (Exception ex)
          {
              Customer c = new Customer();
          }
      }
      
    }
}
