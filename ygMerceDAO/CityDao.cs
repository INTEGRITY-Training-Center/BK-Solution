using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
    public class CityDao
    {
        public List<Cityinfo> selectalcityinfo()
        {
            try
            {
                List<Cityinfo> listcityinfo = new List<Cityinfo>();
                {
                    using (RMSDataContext db = new RMSDataContext())
                    {
                        Cityinfo cityinfo;
                        var a = (from o in db.Cities select o).ToList();
                        foreach (var obj in a)
                        {
                            cityinfo = new Cityinfo();
                            cityinfo.CityID = obj.CityID;
                            cityinfo.City_Name = obj.City_Name;
                            cityinfo.City_Description = obj.City_Descripion;
                            cityinfo.DivisionID = obj.CityID;
                            listcityinfo.Add(cityinfo);


                        }
                        return listcityinfo;
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<Cityinfo>();

            }

        }

        public void InsertCity(Cityinfo cityInfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    City tbl = new City();
                    tbl.CityID = cityInfo.CityID;
                    tbl.City_Name = cityInfo.City_Name;
                    tbl.City_Descripion = cityInfo.City_Description;
                    tbl.State_DivisionID = cityInfo.DivisionID;
                }
            }
            catch (Exception ex)
            {
                City city = new City();
            }
        }
        public void UpdateCityByID(Cityinfo cinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Cities where a.CityID == cinfo.CityID select a).First();
                    obj.CityID = cinfo.CityID;
                    obj.City_Name = cinfo.City_Name;
                    obj.City_Descripion = cinfo.City_Description;
                    obj.State_DivisionID = cinfo.DivisionID;
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                City city = new City();
            }
        }
        public void DeleteCityByID(Cityinfo cinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Cities where a.CityID == cinfo.CityID select a).First();
                    db.Cities.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                City city = new City();
            }
        }
    }
}