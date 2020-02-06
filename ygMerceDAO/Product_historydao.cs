using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class Product_historydao
    {
        public List<Product_historyinfo> SelectallProduct_historyinfo()
        {
            try {
                List<Product_historyinfo> lstpinfo = new List<Product_historyinfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    Product_historyinfo pinfo;
                    var b=(from c in db.product_histories select c).ToList();
                    foreach (var obj in b)
                    {

                        pinfo = new Product_historyinfo();
                        pinfo.ProductID = obj.ProductID;
                        pinfo.ProductName = obj.ProductName;
                        pinfo.Product_image = obj.Product_image;
                        pinfo.Product_imageID = obj.Product_imageID;
                        pinfo.Product_description = obj.Product_Description;
                        pinfo.Category = obj.Category;
                        pinfo.BrandName = obj.BrandName;
                        pinfo.BrandID = obj.BrandID;
                        pinfo.Color = obj.Color;
                        pinfo.Size = obj.Size;
                        pinfo.Purchase_price =Convert.ToDecimal( obj.Purchase_price);
                        pinfo.Manufacture_date = obj.Manufacture_date;
                        pinfo.Product_Expired_date = obj.Product_Expired_date;
                        pinfo.Manufacture_Country = obj.Manufacture_Country.ToString();
                        pinfo.Inserted_date = obj.Inserted_date;
                        lstpinfo.Add(pinfo);
                    }
                    return lstpinfo;
                }



            
            
            
            }
            catch (Exception ex)
            {
                return new List<Product_historyinfo>();
            }
        }

        public void InsertProduct_History(Product_historyinfo phinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                product_history pd = new product_history();
                pd.ProductID = phinfo.ProductID;
                pd.ProductName = phinfo.ProductName;
                pd.Product_image = phinfo.Product_image;
                pd.Product_imageID = phinfo.Product_imageID;
                pd.Product_Description = phinfo.Product_description;
                pd.Category = phinfo.Category;
                pd.BrandID = phinfo.BrandID;
                pd.Color = phinfo.Color;
                pd.Size = phinfo.Size;
                pd.Purchase_price =Convert.ToString(phinfo.Purchase_price);
                pd.Product_Expired_date = phinfo.Product_Expired_date;
                pd.Inserted_date = phinfo.Inserted_date;
                //pd.Manufacture_Country = phinfo.Manufacture_Country;

                db.product_histories.InsertOnSubmit(pd);
                db.SubmitChanges();
            }
        }
        public void product_historyupdateupdateid(Product_historyinfo productid)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.product_histories where o.ProductID == productid.ProductID select o).First();
                    obj.ProductID = productid.ProductID;
                    obj.ProductName = productid.ProductName;
                    obj.Product_imageID = productid.Product_imageID;
                    obj.Product_image = productid.Product_image;
                    obj.Product_Description = productid.Product_description;
                    obj.Manufacture_date = productid.Manufacture_date;
                    obj.Manufacture_Country = Convert.ToDateTime(productid.Manufacture_Country);
                    obj.Manufacture_date = productid.Manufacture_date;
                    obj.Product_Expired_date = productid.Product_Expired_date;
                    obj.Purchase_price = productid.Purchase_price.ToString();
                    obj.Size = productid.Size;
                    obj.Category = productid.Category;
                    obj.Color = productid.Color;
                    obj.BrandID = productid.BrandID;
                    obj.BrandName = productid.BrandName;
                    db.SubmitChanges();




                }
            }
            catch(Exception ex)
            {
                Product_historyinfo product_his = new Product_historyinfo();
            }


        }
        public void deleteproducthistory(Product_historyinfo deleteproducthis)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.product_histories where o.ProductID == deleteproducthis.ProductID select o).First();
                    db.product_histories.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                Product_historyinfo product_his = new Product_historyinfo();
            }
        }
    }
}

