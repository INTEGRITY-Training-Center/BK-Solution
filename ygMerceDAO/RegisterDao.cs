using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;
using System.IO;



namespace ygMerceDAO
{
   public class RegisterDao
    {
       public List<RegisterInfo> SelectallRegisterinfo()
        {
           try
             {
                List<RegisterInfo> lstinfo =new List<RegisterInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    RegisterInfo rinfo;
                    var a = (from o in db.Registers select o).ToList();
                    foreach (var obj in a)
                    {
                        rinfo=new RegisterInfo();
                        rinfo.RegisterID = obj.ID;
                        rinfo.UserName  = obj.UserName;
                        rinfo.NRC = obj.NRC;
                        rinfo.DOB = obj.DOB;
                        rinfo.Picture = (obj.Picture.ToArray());
                        
                        rinfo.Address = obj.Address;
                        rinfo.Gender = obj.Gender;
                        rinfo.Phone = obj.Phone;
                        rinfo.Password = obj.Password;
                        rinfo.Email = obj.Email;
                        rinfo.InsertDate = obj.InsertedDate;
                        //rinfo.UpdateDate = obj.UpdatedDate;
                        lstinfo.Add(rinfo);
                    }
                    return lstinfo;
                }
              }
           catch (Exception ex)
           {
               return new List<RegisterInfo>();
           }
        }

       public void InsertRegister(RegisterInfo reginfo)
       {
           try
           {
               using(RMSDataContext db=new RMSDataContext ())
               {
                   Register reg = new Register();
                   Guid id;
                   id=Guid.NewGuid();
                   reg.ID = id.ToString();
                   reg.UserName = reginfo.UserName;
                   reg.NRC = reginfo.NRC;
                   reg.DOB = reginfo.DOB;
                   System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(reginfo.Picture);
                   reg.Picture = file_binary;
                   reg.Address = reginfo.Address;
                   reg.Gender = reginfo.Gender;
                   reg.Phone = reginfo.Phone;
                   reg.Password = reginfo.Password;
                   reg.Email = reginfo.Email;
                   reg.InsertedDate = DateTime.UtcNow.AddMinutes(390);
                   reg.UpdatedDate = DateTime.UtcNow.AddMinutes(390);

                   db.Registers.InsertOnSubmit(reg);
                   db.SubmitChanges();
               }
           }
           catch
           {
               Register a = new Register();
           }
       }
       public void UpdateRegisterByRegisterID(RegisterInfo Reginfo)
       {
           try
           {
               using (RMSDataContext db = new RMSDataContext())
               {
                   var obj = (from a in db.Registers where a.ID == Reginfo.RegisterID select a).First();
                   obj.ID = Reginfo.RegisterID;
                   obj.UserName = Reginfo.UserName;
                   obj.NRC = Reginfo.NRC;
                   obj.DOB = Reginfo.DOB;
                   obj.Picture = Reginfo.Picture;
                   obj.Address = Reginfo.Address;
                   obj.Gender = Reginfo.Gender;
                   obj.Phone = Reginfo.Phone;
                   obj.Password = Reginfo.Password;
                   obj.Email = Reginfo.Email;
                   obj.UpdatedDate = Reginfo.UpdateDate;
                   db.SubmitChanges();


               }
           }
           catch (Exception ex)
           {
               Register Reg = new Register();
           } 
       }

        public void DeleteRegisterByRegister(RegisterInfo Reginfo)
       {
           try
           {
               using (RMSDataContext db = new RMSDataContext())
               {
                   var obj = (from a in db.Registers where a.ID == Reginfo.RegisterID select a).First();
                   db.Registers.DeleteOnSubmit(obj);
                   db.SubmitChanges();
               }
           }
           catch (Exception ex)
           {
               Register Reg = new Register();

           }
       }


        private void StoreImage(RegisterInfo Reginfo)
        {
            // Open the DataContext
            using (RMSDataContext db = new RMSDataContext())
            {
                try
                {
                    // Convert System.Drawing.Image to a byte[]
                    //byte[] file_byte = Reginfo.Picture;
                    // Create a System.Data.Linq.Binary - this is what an "image" column is mapped to
                    System.Data.Linq.Binary file_binary = new System.Data.Linq.Binary(Reginfo.Picture);
                    Register img = new Register
                    {
                        Picture = file_binary
                        
                    };
                    db.Registers.InsertOnSubmit(img);
                }
                finally
                {
                    // Save
                    db.SubmitChanges();
                }
            }
        }

        //private void buttonRetireveImageFromDb_Click(object sender, EventArgs e)
        //{
        //    // Open the DataContext
        //    Database1 db = new Database1("Data Source=Database1.sdf");

        //    // Get as single image from the database
        //    var img = (from image in db.Images
        //               where image.ImageName == "Erik testing"
        //               select image).Single();
        //    // Convert the byte[] to an System.Drawing.Image
        //    pictureBox1.Image = ByteArrayToImage(img.Image.ToArray());
        //}

       
       
    }
}
