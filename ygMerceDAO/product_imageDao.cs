using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
     public class product_imageDao
    {
         public void InsertProductImages(product_imageinfo piInf) 
         {
             try
             {
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     product_image1 pr = new product_image1();
                     Guid prid=new Guid ();

                     pr.Product_imageID=prid.ToString();
                     System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(piInf.Images);
                     pr.Images = file_binary;
                     //System.Data.Linq.Binary file_binary_Main = new System.Data.Linq.Binary(piInf.MainPic);
                     //pr.MainPic = file_binary_Main;
                     pr.ProductID = piInf.ProductID;
                     db.product_image1s.InsertOnSubmit(pr);
                     db.SubmitChanges();
                 }
             }
             catch (Exception ex) { }
         }

         public List<product_imageinfo> Selectallproduct_imagecs()
         {
             try
             {
                 List<product_imageinfo> lstpiinfo = new List<product_imageinfo>();
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     product_imageinfo piinfo;
                     var a = (from o in db.product_image1s select o).ToList();
                     foreach (var obj in a)
                     {
                         piinfo = new product_imageinfo();
                         piinfo.Product_imageID = obj.Product_imageID;
                         piinfo.Images = (obj.Images.ToArray());
                         piinfo.MainPic = obj.MainPic;
                         lstpiinfo.Add(piinfo);



                     }
                     return lstpiinfo;
                 }
             }


             catch (Exception ex)
             {

                 return new List<product_imageinfo>();
             }


         }

         public void InsertProductImage(product_imageinfo pinfo)
         {
             try
             {
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     product_image1 pim = new product_image1();
                     Guid pid = Guid.NewGuid();
                     pim.Product_imageID = pid.ToString();
                     pim.ProductID = pinfo.ProductID;
                     System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(pinfo.Images);
                     pim.Images = file_binary;
                     pim.MainPic = pinfo.MainPic;
                     db.product_image1s.InsertOnSubmit(pim);
                     db.SubmitChanges();
                 }
             }
             catch (Exception ex) { }
         }

         public void UpdateProductImagebyProductId(product_imageinfo pinfo)
         {
             try
             {
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     var p = (from pp in db.product_image1s where pp.Product_imageID == pinfo.Product_imageID select pp).First();

                     p.Product_imageID = pinfo.Product_imageID;
                     p.Images = pinfo.Images;

                     db.SubmitChanges();
                 }
             }
             catch (Exception ex)
             {
                 product_imageinfo pi = new product_imageinfo();
             }
         }
         public void DelectProductImagebyProductimgId(product_imageinfo pinfo)
     
         {
             try
             {
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     var p = (from pp in db.product_image1s where pp.Product_imageID == pinfo.Product_imageID select pp).First();

                     db.product_image1s.DeleteOnSubmit(p);
                     db.SubmitChanges();
                 }
             }
             catch (Exception ex)
             {
                 product_imageinfo pi = new product_imageinfo();
             }
         }

         


         public List<product_imageinfo> SelectByID(string productID)
         {
             try
             {
                 List<product_imageinfo> lstpiinfo = new List<product_imageinfo>();
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     product_imageinfo piinfo;
                     var a = (from o in db.product_image1s where o.ProductID==productID && o.MainPic==false select o).ToList();
                     foreach (var obj in a)
                     {
                         piinfo = new product_imageinfo();
                         piinfo.Product_imageID = obj.Product_imageID;
                         piinfo.Images = (obj.Images.ToArray());
                         piinfo.MainPic = obj.MainPic;
                         lstpiinfo.Add(piinfo);
                     }
                     return lstpiinfo;
                 }
             }


             catch (Exception ex)
             {

                 return new List<product_imageinfo>();
             }


         }
    }
}
