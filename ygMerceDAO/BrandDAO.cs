using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class BrandDAO
    {
        brandinfoinfo binfo = new brandinfoinfo();

        public List<brandinfoinfo> selectAllBrandInfo()
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    List<brandinfoinfo> lstbrinfo = new List<brandinfoinfo>();
                    {
                        brandinfoinfo binfo;
                        var b = (from br in db.brands select br).ToList();

                        foreach (var obj in b)
                        {
                            binfo = new brandinfoinfo();

                            binfo.BrandID = obj.BrandID;
                            binfo.BrandName = obj.BrandName;
                            binfo.Model = obj.Model;
                            binfo.CategoryID = obj.CategoryID;
                            lstbrinfo.Add(binfo);
                        }

                        return lstbrinfo;
                    }

                }
            }
            catch (Exception ex)
            {
                return new List<brandinfoinfo>();
            }

        }


        public List<brandinfoinfo> selectAllBrandInfoCatID(string cat)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    List<brandinfoinfo> lstbrinfo = new List<brandinfoinfo>();
                    {
                        brandinfoinfo binfo;
                        var b = (from br in db.brands where br.CategoryID==cat select br).ToList();

                        foreach (var obj in b)
                        {
                            binfo = new brandinfoinfo();

                            binfo.BrandID = obj.BrandID;
                            binfo.BrandName = obj.BrandName;
                            binfo.Model = obj.Model;
                            binfo.CategoryID = obj.CategoryID;
                            lstbrinfo.Add(binfo);
                        }

                        return lstbrinfo;
                    }

                }
            }
            catch (Exception ex)
            {
                return new List<brandinfoinfo>();
            }

        }
        public brandinfoinfo selectBrandInfoByBrandID(brandinfoinfo brinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {

                    brandinfoinfo binfo;
                    var b = (from a in db.brands where a.BrandID == brinfo.BrandID select a).First();

                    binfo = new brandinfoinfo();

                    binfo.BrandID = b.BrandID;
                    binfo.BrandName = b.BrandName;
                    binfo.CategoryID = b.CategoryID;
                    binfo.Model = b.Model;

                    return binfo;
                }
                
            }
            catch (Exception ex)
            {
                return new brandinfoinfo();
            }

        }


        public void InsertBrand(brandinfoinfo brinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    brand tbl = new brand();
                    Guid bid = Guid.NewGuid();

                    tbl.BrandID = bid.ToString();
                    tbl.BrandName = brinfo.BrandName;
                    tbl.Model = brinfo.Model;
                    tbl.CategoryID = brinfo.CategoryID;
                    db.brands.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                brand tbl = new brand();
            }
        }

        public void UpdateBrandByUpdateID(brandinfoinfo brinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                var obj = (from a in db.brands where a.BrandID == brinfo.BrandID select a).First();
               
                obj.BrandID = brinfo.BrandID;
                obj.BrandName = brinfo.BrandName;
                obj.Model = brinfo.Model;
                
                db.SubmitChanges();
            }
        }

        public void deleteBrand(brandinfoinfo brinfo)
        {

            using (RMSDataContext db = new RMSDataContext())
            {
                var obj = (from a in db.brands where a.BrandID == brinfo.BrandID select a).First();
                db.brands.DeleteOnSubmit(obj);
                db.SubmitChanges();
            }

        }
    }
}
