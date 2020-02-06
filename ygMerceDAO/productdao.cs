using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
   public class productdao
    {

       public List<Productinfo> SelectallProductinfo()
       {
           try
           {
               List<Productinfo> lstpinfo = new List<Productinfo>();
               using (RMSDataContext db = new RMSDataContext())
               {
                   Productinfo pinfo;
                   var b = (from c in db.products select c).ToList();
                   foreach (var obj in b)
                   {

                       pinfo = new Productinfo();
                      
                       pinfo.ProductID = obj.ProductID;
                       pinfo.ProductName = obj.ProductName;
                       pinfo.Product_description = obj.Product_description;
                       pinfo.CategoryID = obj.CategoryID;
                       pinfo.SupplierID = obj.SupplierID;
                       pinfo.BrandID = obj.BrandID;
                       pinfo.UMID = obj.UMID;
                       pinfo.Color = obj.Color;
                       pinfo.Size = obj.Size;
                       pinfo.UnitPrice = obj.UnitPrice;
                       pinfo.Manufacture_date = obj.Manufacture_date;
                       pinfo.Product_Expired_date = obj.Product_Expired_date;
                       pinfo.Manufacture_Country = obj.Manufacture_Country.ToString();
                       pinfo.Inserted_date = obj.Inserted_date;
                       pinfo.Expired_date = obj.Expired_date;

                       lstpinfo.Add(pinfo);
                   }
                   return lstpinfo;
               }

           }
           catch (Exception ex)
           {
               return new List<Productinfo>();
           }
       }

        public string InsertProduct(Productinfo pinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    product tbl = new product();
                    Guid pid = Guid.NewGuid();
                    tbl.ProductID = pid.ToString();
                    tbl.ProductName = pinfo.ProductName;
                    tbl.Product_description = pinfo.Product_description;
                    tbl.Product_Expired_date = pinfo.Product_Expired_date;
                    tbl.Expired_date = pinfo.Expired_date;
                    tbl.BrandID = pinfo.BrandID;
                    tbl.CategoryID = pinfo.CategoryID;
                    tbl.Color = pinfo.Color;
                    tbl.Inserted_date = DateTime.Now;
                    tbl.Manufacture_Country = pinfo.Manufacture_Country;
                    tbl.Manufacture_date = pinfo.Manufacture_date;
                    tbl.SupplierID = pinfo.SupplierID;
                    tbl.UMID = pinfo.UMID;
                    tbl.UnitPrice = pinfo.UnitPrice;
                    tbl.Size = pinfo.Size;
                    db.products.InsertOnSubmit(tbl);
                    db.SubmitChanges();

                    return pid.ToString();
                }
                
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public void UpdateProductByProductId(Productinfo prinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var pr = (from pro in db.products where pro.ProductID == prinfo.ProductID select pro).First();

                    pr.ProductID = prinfo.ProductID;
                    pr.ProductName = prinfo.ProductName;
                    pr.Product_description = prinfo.Product_description;
                    pr.Product_Expired_date = prinfo.Product_Expired_date;
                    pr.BrandID = prinfo.BrandID;
                    pr.CategoryID = prinfo.CategoryID;
                    pr.Color = prinfo.Color;
                    pr.Inserted_date = prinfo.Inserted_date;
                    pr.Manufacture_date = prinfo.Manufacture_date;
                    //pr.Product_image = prinfo.Product_image;
                    //pr.Product_imageID = prinfo.Product_imageID;
                    pr.UnitPrice = prinfo.UnitPrice;
                    pr.Size = prinfo.Size;
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Productinfo p = new Productinfo();
            }
        }

        public void DelectProductByProductId(Productinfo prinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var pr = (from pro in db.products where pro.ProductID == prinfo.ProductID select pro).First();

                    db.products.DeleteOnSubmit(pr);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Productinfo p = new Productinfo();
            }

        }

        public Productinfo SelectByID(string productID)
        {
            try
            {
               
                using (RMSDataContext db = new RMSDataContext())
                {
                    Productinfo pinfo = new Productinfo();
                    var obj = (from dt in db.products where dt.ProductID == productID select dt).First();

                    pinfo.ProductID = obj.ProductID;
                    pinfo.ProductName = obj.ProductName;
                    pinfo.Product_description = obj.Product_description;
                    pinfo.CategoryID = obj.CategoryID;
                    pinfo.SupplierID = obj.SupplierID;
                    pinfo.BrandID = obj.BrandID;
                    pinfo.UMID = obj.UMID;
                    pinfo.Color = obj.Color;
                    pinfo.Size = obj.Size;
                    pinfo.UnitPrice = obj.UnitPrice;
                    pinfo.Manufacture_date = obj.Manufacture_date;
                    pinfo.Product_Expired_date = obj.Product_Expired_date;
                    pinfo.Manufacture_Country = obj.Manufacture_Country.ToString();
                    pinfo.Inserted_date = obj.Inserted_date;
                    pinfo.Expired_date = obj.Expired_date;
                    
                    return pinfo;
                }

            }
            catch (Exception ex)
            {
                return new Productinfo();
            }
        }

        public List<Productinfo> SelectProductsByCategoryId(string categoryId)
        {
            try
            {
                List<Productinfo> lstpinfo = new List<Productinfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    Productinfo pinfo;
                    var b = (from c in db.products where c.CategoryID == categoryId select c).ToList();
                    foreach (var obj in b)
                    {

                        pinfo = new Productinfo();

                        pinfo.ProductID = obj.ProductID;
                        pinfo.ProductName = obj.ProductName;
                        pinfo.Product_description = obj.Product_description;
                        pinfo.CategoryID = obj.CategoryID;
                        pinfo.SupplierID = obj.SupplierID;
                        pinfo.BrandID = obj.BrandID;
                        pinfo.UMID = obj.UMID;
                        pinfo.Color = obj.Color;
                        pinfo.Size = obj.Size;
                        pinfo.UnitPrice = obj.UnitPrice;
                        pinfo.Manufacture_date = obj.Manufacture_date;
                        pinfo.Product_Expired_date = obj.Product_Expired_date;
                        pinfo.Manufacture_Country = obj.Manufacture_Country.ToString();
                        pinfo.Inserted_date = obj.Inserted_date;
                        pinfo.Expired_date = obj.Expired_date;

                        lstpinfo.Add(pinfo);
                    }
                    return lstpinfo;
                }

            }
            catch (Exception ex)
            {
                return new List<Productinfo>();
            }
        }
    }
}
