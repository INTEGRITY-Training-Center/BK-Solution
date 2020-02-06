using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;
namespace ygMerceDAO
{
    public class CategoryDAO
    {
        #region Select All Category
        public List<Categoryinfo> SelectAllCategory()
        {
            try
            {
                List<Categoryinfo> cObj = new List<Categoryinfo>();
                using (RMSDataContext db = new RMSDataContext())
                {

                    var hp = (from c in db.Categories orderby c.Type select c).ToList();
                    foreach (var obj in hp)
                    {
                        Categoryinfo cInfo = new Categoryinfo();
                        cInfo.CategoryID = obj.CategoryID;
                        cInfo.Description = obj.Description;
                        cInfo.Type = obj.Type;

                        cObj.Add(cInfo);
                    }
                    return cObj;
                }
            }
            catch (Exception ex)
            {
                return new List<Categoryinfo>();
            }

        }

        #endregion

        #region InsertCategory
        public void InsertCategory(Categoryinfo cInfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    Category tbl = new Category();
                    Guid cId = Guid.NewGuid();
                    tbl.CategoryID = cId.ToString();
                    tbl.Type = cInfo.Type;
                    tbl.Description = cInfo.Description;

                    db.Categories.InsertOnSubmit(tbl);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Category tbl = new Category();
            }
        }
    #endregion
        public void UpdateCategoryByID(Categoryinfo cInfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Categories where a.CategoryID == cInfo.CategoryID select a).First();
                    obj.CategoryID = cInfo.CategoryID;
                    obj.Type = cInfo.Type;
                    obj.Description = cInfo.Description;
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                Category tbl = new Category();
            }
        }

        public void DeleteCategoryByID(Categoryinfo cinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Categories where a.CategoryID == cinfo.CategoryID select a).First();
                    db.Categories.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Category tbl = new Category();
            }
        }

        //public List<Categoryinfo> SelectCategoryById()
        //{
        //    try
        //    {
        //        List<Categoryinfo> cObj = new List<Categoryinfo>();
        //        using (RMSDataContext db = new RMSDataContext())
        //        {

        //            var hp = (from c in db.Categories select c).ToList();
        //            foreach (var obj in hp)
        //            {
        //                Categoryinfo cInfo = new Categoryinfo();
        //                cInfo.CategoryID = obj.CategoryID;
        //                cInfo.Description = obj.Description;
        //                cInfo.Type = obj.Type;

        //                cObj.Add(cInfo);
        //            }
        //            return cObj;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return new List<Categoryinfo>();
        //    }

        //}
    }
}