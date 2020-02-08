using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
    public class BKCustomerDAO
    {
        public List<BKCustomerInfo> selectallBKCustomerInfo()
        {
            try
            {
                List<BKCustomerInfo> listBKCustomerInfo = new List<BKCustomerInfo>();
                {
                    using (RMSDataContext db = new RMSDataContext())
                    {
                        BKCustomerInfo BKCustomerInfo;
                        var a = (from o in db.BKCustomers select o).ToList();
                        foreach (var obj in a)
                        {
                            BKCustomerInfo = new BKCustomerInfo();
                            BKCustomerInfo.CustomerID = obj.CustomerID;
                            BKCustomerInfo.CustomerCode = obj.Customercode;
                            BKCustomerInfo.Name = obj.Name;
                            BKCustomerInfo.TownshipID = obj.TownshipID;
                            BKCustomerInfo.Contact = obj.Contact;
                            BKCustomerInfo.address = obj.Address;
                            BKCustomerInfo.InsertDate = obj.InsertDate;
                            BKCustomerInfo.UpdateDate = obj.UpdateDate;
                            listBKCustomerInfo.Add(BKCustomerInfo);

                        }
                        return listBKCustomerInfo;
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<BKCustomerInfo>();
            }

        }

        public int selectallBKCustomerInfoByMobile(string mb)
        {
            try
            {
                List<BKCustomerInfo> listBKCustomerInfo = new List<BKCustomerInfo>();
                {
                    using (RMSDataContext db = new RMSDataContext())
                    {
                        
                        var a = (from o in db.BKCustomers where o.Contact==mb select o).ToList();
                       
                        return a.Count;
                    }
                }
            }
            catch (Exception ex)
            {
                return 1;
            }

        }
        public string insert_customer(BKCustomerInfo custinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    BKCustomer custbl = new BKCustomer();
                    //custbl.CustomerID = custinfo.CustomerID;
                    custbl.Name = custinfo.Name;
                    custbl.Address = custinfo.address;
                    custbl.Contact = custinfo.Contact;
                    //custbl.CustomerPassword = custinfo.CustomerPassword;


                    //custbl.TownshipID = custinfo.TownshipID;
                    custbl.InsertDate = custinfo.InsertDate;
                    custbl.UpdateDate = custinfo.UpdateDate;
                    db.BKCustomers.InsertOnSubmit(custbl);
                    db.SubmitChanges();

                    return custinfo.Name;
                }
            }
            catch(Exception ex)
            {
                return string.Empty;
            }
        }

        public void UpdateCustomerByCustomerID(BKCustomerInfo custinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from customer in db.BKCustomers
                               where customer.Customercode == custinfo.CustomerCode
                               select customer).First();

                    
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
        public void DeleteCustomerByCustomerID(BKCustomerInfo custinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from cust in db.BKCustomers
                               where cust.Customercode == custinfo.CustomerCode
                               select cust).First();

                    db.BKCustomers.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Customer c = new Customer();
            }
        }

        public int Login(string cuscode,string pw)
        {
           
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from cust in db.BKCustomers
                               where cust.Contact == cuscode && cust.CustomerPassword == pw
                               select cust).ToList();

                    return obj.Count;
                }
               
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
