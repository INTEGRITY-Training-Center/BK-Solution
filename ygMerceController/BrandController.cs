using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class BrandController
    {
        brandinfoinfo brinfo ;
        BrandDAO brDao=new BrandDAO () ;
        List<brandinfoinfo> lstBrand ;
        public List<brandinfoinfo> SelectAllBrandInfo()
        {
            lstBrand = new List<brandinfoinfo>();
            lstBrand = brDao.selectAllBrandInfo();
            return lstBrand;
        }
        public List<brandinfoinfo> SelectAllBrandInfoByCategoryID(string cat)
        {
            lstBrand = new List<brandinfoinfo>();
            lstBrand = brDao.selectAllBrandInfoCatID(cat);
            return lstBrand;
        }

        public brandinfoinfo SelectBrandByBrandID(brandinfoinfo bfo)
        {
            brinfo = new brandinfoinfo();
            brinfo = brDao.selectBrandInfoByBrandID(bfo);
            return brinfo;
        }

        

        public void InsertBrandByBrandID(brandinfoinfo bfo)
        {
            brDao.InsertBrand(bfo);
        }
        public void UpdateBrandByBrandID(brandinfoinfo bfo)
        {
            brDao.UpdateBrandByUpdateID(bfo);
        }
        public void DeleteBrandByBrandID(brandinfoinfo bfo)
        {
            brDao.deleteBrand(bfo);
        }
    }


}
