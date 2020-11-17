using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class BK_ProductDAO
    {
        public List<BK_ProductInfo> SelectallBKProductinfo()
        {
            try
            {
                List<BK_ProductInfo> lstpinfo = new List<BK_ProductInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    BK_ProductInfo pinfo;
                    var b = (from c in db.BK_Products select c).ToList();
                    foreach (var obj in b)
                    {

                        pinfo = new BK_ProductInfo();

                        pinfo.BK_ProductID = obj.BK_ProductID;
                        pinfo.BK_ProductName = obj.BK_ProductName;
                        pinfo.BK_Price = obj.BK_Price;
                        pinfo.CategoryID = obj.CategoryID;
                        
                        pinfo.UMID = obj.UMID;
                       
                        //pinfo.InsertedDate = obj.InsertedDate;
                        //pinfo.UpdatedDate = obj.UpdatedDate;

                        lstpinfo.Add(pinfo);
                    }
                    return lstpinfo;
                }

            }
            catch (Exception ex)
            {
                return new List<BK_ProductInfo>();
            }
        }

        public bool InsertBK_ProductByList(List<BK_ProductInfo> bklst)
        {
            bool b = false;

            foreach(var obj in bklst)
            {
                try
                {
                    b= InsertBK_Product(obj);
                    
                }
                catch (Exception ex)
                {
                    b = false;
                }

            }

            return b;
        }

        public bool InsertBK_Product(BK_ProductInfo pinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    BK_Product tbl = new BK_Product();
                    Guid pid = Guid.NewGuid();
                    tbl.BK_ProductID = pid.ToString();
                    tbl.BK_ProductName = pinfo.BK_ProductName;
                   
                    tbl.CategoryID = pinfo.CategoryID;
                   
                    tbl.UMID = "48ec165d-d28e-4354-94d7-40636daa7d4f";
                    tbl.BK_Price = 100.00m;

                    tbl.InsertedDate = DateTime.UtcNow.AddMinutes(390).Date;
                   tbl.UpdatedDate = DateTime.UtcNow.AddMinutes(390).Date;
                    db.BK_Products.InsertOnSubmit(tbl);
                    db.SubmitChanges();

                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
