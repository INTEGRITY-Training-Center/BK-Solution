using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class CategoryController
    {
        CategoryDAO catDao = new CategoryDAO();
        List<Categoryinfo> lstCategory;

        public List<Categoryinfo> SelectAllCategoryInfo()
        {
            lstCategory = new List<Categoryinfo>();
            lstCategory = catDao.SelectAllCategory();

            return lstCategory;
        }
public void InsertCategory(Categoryinfo cinfo)
        {
            catDao.InsertCategory(cinfo); 
        }
        public void UpdateCategory(Categoryinfo cinfo)
        {
            catDao.UpdateCategoryByID(cinfo);
        }
        public void DeleteCategory(Categoryinfo cinfo)
        {
            catDao.UpdateCategoryByID(cinfo);
        }

    }
}
