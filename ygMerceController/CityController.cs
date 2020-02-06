using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class CityController
    {
        CityDao cityDao = new CityDao();
        List<Cityinfo> lstCity;

        public List<Cityinfo> SelectAllCity()
        {
            lstCity = new List<Cityinfo>();
            lstCity = cityDao.selectalcityinfo();

            return lstCity;
        }
        public void InsertCity(Cityinfo cinfo)
        {
            cityDao.InsertCity(cinfo);
        }
        public void UpdateCity(Cityinfo cinfo)
        {
            cityDao.UpdateCityByID(cinfo);
        }
        public void DeleteCity(Cityinfo cinfo)
        {
            cityDao.DeleteCityByID(cinfo);
        }
    }
}
