using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
     public class product_imagesdao
    {

         public List<product_imageinfo> Selectallproduct_imagecs()
         {
             try
             {
                 List<product_imageinfo> lstpiinfo = new List<product_imageinfo>();
                 using (RMSDataContext db = new RMSDataContext())
                 {
                     product_imageinfo piinfo;
                     var a = (from o in db.product_images select o).ToList();
                     foreach (var obj in a)
                     {
                         piinfo = new product_imageinfo();
                         piinfo.Product_imageID = obj.Product_imageID;
                         piinfo.Images = obj.Images;
                       
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
        public void Insertproduct_images( product_imageinfo pinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                product_image tbl = new product_image();
                tbl.Product_imageID = pinfo.Product_imageID;
                tbl.Images = pinfo.Images;
                db.product_images.InsertOnSubmit(tbl);
                db.SubmitChanges();
            }
        }      
    }
}
