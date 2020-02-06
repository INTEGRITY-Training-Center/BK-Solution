using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;
namespace ygMerceDAO
{
    public class SupplierDAO
    {
        public void InsertSupplierInfo(SupplierInfo sinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    Supplier sup = new Supplier();
                    Guid sid = Guid.NewGuid();
                    sup.SupplierID = sid.ToString();
                    sup.SupplierName = sinfo.SupplierName;
                    sup.SupplierEmail = sinfo.SupplierEmail;
                    sup.SupplierAddress = sinfo.SupplierAddress;
                    sup.SupplierPhoneNo = sinfo.SupplierPhoneNo;
                    sup.InsertedDate = DateTime.UtcNow.AddMinutes(390);
                    sup.UpdatedDate = DateTime.UtcNow.AddMinutes(390);

                    db.Suppliers.InsertOnSubmit(sup);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            { }
        }

        public List<SupplierInfo> SelectAllSupplierInfo()
        {
            try
            {
                List<SupplierInfo> lstSupplierInfo = new List<SupplierInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    var hp = (from s in db.Suppliers select s).ToList();
                    foreach (var one in hp)
                    {
                        SupplierInfo sObj = new SupplierInfo();
                        sObj.SupplierID = one.SupplierID;
                        sObj.SupplierName = one.SupplierName;
                        sObj.SupplierAddress = one.SupplierAddress;
                        sObj.SupplierEmail = one.SupplierEmail;
                        sObj.SupplierPhoneNo = one.SupplierPhoneNo;
                        sObj.InsertedDate = one.InsertedDate;

                        lstSupplierInfo.Add(sObj);
                    }

                    return lstSupplierInfo;
                }
            }
            catch (Exception ex)
            {
                return new List<SupplierInfo>();
            }
        }

        public void UpdateSupplierBySupplierID(SupplierInfo SuppInfo)
        {
            try
            {


                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Suppliers where a.SupplierID == SuppInfo.SupplierID select a).First();
                    obj.SupplierID = SuppInfo.SupplierID;
                    obj.SupplierName = SuppInfo.SupplierName;
                    obj.SupplierPhoneNo = SuppInfo.SupplierPhoneNo;
                    obj.SupplierAddress = SuppInfo.SupplierAddress;
                    obj.SupplierEmail = SuppInfo.SupplierEmail;
                    obj.UpdatedDate = SuppInfo.UpdatedDate;
                    db.SubmitChanges();

                }
            }
            catch(Exception ex)
            {
                Supplier tbl = new Supplier();
            }
        }

        public void DeleteSupplierBySupplierID(SupplierInfo SuppInfo)
        {
            try
            {


                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Suppliers where a.SupplierID == SuppInfo.SupplierID select a).First();
                    db.Suppliers.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                Supplier tbl = new Supplier();
            }
        }
    }
}
