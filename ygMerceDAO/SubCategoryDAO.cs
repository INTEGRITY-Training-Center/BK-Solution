using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
    public class SubCategoryDAO
    {
        public List<SubCategoryInfo> SelectAllSubCategoryInfo()
        {
            try
            {
                List<SubCategoryInfo> lstSubCategoryInfo = new List<SubCategoryInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    var hp = (from sc in db.SubCategories select sc).ToList();
                    foreach (var one in hp)
                    {
                        SubCategoryInfo scObj = new SubCategoryInfo();
                        scObj.SubCategoryID = one.SubCategoryID;
                        scObj.Type = one.Type;
                        scObj.Description = one.Description;
                        scObj.CategoryID = one.CategoryID;
                        //scObj.InsertedDate = one.InsertedDate;

                        lstSubCategoryInfo.Add(scObj);
                    }

                    return lstSubCategoryInfo;
                }
            }
            catch (Exception ex)
            {
                return new List<SubCategoryInfo>();
            }
        }

        public void UpdateSubCategoryBySubCategoryID(SubCategoryInfo SCInfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.SubCategories where a.SubCategoryID == SCInfo.SubCategoryID select a).First();
                    obj.SubCategoryID = SCInfo.SubCategoryID;
                    obj.Type = SCInfo.Type;
                    obj.Description = SCInfo.Description;
                    obj.CategoryID = SCInfo.CategoryID;
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                SubCategory tbl = new SubCategory();
            }
        }

        public void DeleteSubCategoryBySubCategoryID(SubCategoryInfo SCInfo)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.SubCategories where a.SubCategoryID == SCInfo.SubCategoryID select a).First();
                    db.SubCategories.DeleteOnSubmit(obj);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                SubCategory tbl = new SubCategory();
            }
        }
    }
}
