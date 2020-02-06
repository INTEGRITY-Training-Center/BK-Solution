using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class CountryDao
    {
        public List<Countryinfo> selectallcountryinfo()
        {
            try
            {
                List<Countryinfo> listcountryinfo = new List<Countryinfo>();
                {
                    using (RMSDataContext db = new RMSDataContext())
                    {
                        Countryinfo countryinfo;
                        var a = (from o in db.Countries select o).ToList();
                        foreach (var obj in a)
                        {
                            countryinfo = new Countryinfo();
                            countryinfo.CountryID = obj.CountryID;
                            countryinfo.Country_Name = obj.Country_Name;
                            countryinfo.Country_Code = obj.Country_Code;
                            countryinfo.Country_Description = obj.Country_Description;
                            countryinfo.RegionID =obj.RegionID;
                            listcountryinfo.Add(countryinfo);

                        }
                        return listcountryinfo;
                    }
                }
            }
                catch(Exception ex)
            {
                    return new List<Countryinfo>();

                }

            
        }
        public void insertcountry(Countryinfo couninfo)
        {
        using(RMSDataContext db=new RMSDataContext())
        {
            Country contrytbl = new Country();
            contrytbl.CountryID = couninfo.CountryID;
            contrytbl.Country_Name = couninfo.Country_Name;
            contrytbl.Country_Code = couninfo.Country_Code;
            contrytbl.Country_Description = couninfo.Country_Description;
            contrytbl.RegionID=couninfo.RegionID;

            db.Countries.InsertOnSubmit(contrytbl);
            db.SubmitChanges();
        }

        }
        public void UpdateCountryByCountryID(Countryinfo couninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from country in db.Countries 
                               where country.CountryID==couninfo.CountryID 
                               select country).First();

                    obj.Country_Name = couninfo.Country_Name;
                    obj.Country_Description = couninfo.Country_Description;
                    obj.Country_Code = couninfo.Country_Code;
                    obj.RegionID = couninfo.RegionID;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Country coun = new Country();
            }
        }
        public void DeleteCountryByCountryID(Countryinfo couninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from c in db.Countries 
                               where c.CountryID == couninfo.CountryID 
                               select c).First();

                    db.Countries.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Country c = new Country();
            }
        }

    }
}
