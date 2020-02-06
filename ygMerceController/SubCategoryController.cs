using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class SubCategoryController
    {
        SubCategoryInfo scInfo = new SubCategoryInfo();
        SubCategoryDAO scDao = new SubCategoryDAO();

        public List<SubCategoryInfo> SelectAllSubCategoryInfo()
        {
            List<SubCategoryInfo> lstSubCategory = new List<SubCategoryInfo>();
            lstSubCategory = scDao.SelectAllSubCategoryInfo();
            return lstSubCategory;


        }
        public void InsertSubCategory(SubCategoryInfo SCInfo)
        {
            
        }

        public void UpdateSubCategory(SubCategoryInfo SCInfo)
        {
            scDao.UpdateSubCategoryBySubCategoryID(SCInfo);
        }

        public void DeleteSubCategory(SubCategoryInfo SCInfo)
        {
            scDao.DeleteSubCategoryBySubCategoryID(SCInfo);
        }
    }
}