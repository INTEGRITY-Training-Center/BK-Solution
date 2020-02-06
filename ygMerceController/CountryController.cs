using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
   public class Countrycontroller
    {
       
       CountryDao countrydao = new CountryDao();
       List<Countryinfo> listconuntryinfo = new List<Countryinfo>();
       public List<Countryinfo> selectallcountryinfo()
       {
           listconuntryinfo = new List<Countryinfo>();
           listconuntryinfo = countrydao.selectallcountryinfo();
           return listconuntryinfo;
       }
       public void InsertCountry(Countryinfo countryInfo)
       {
           countrydao.insertcountry(countryInfo);
       }
       public void UpdateCountry(Countryinfo countryInfo)
       {
           countrydao.UpdateCountryByCountryID(countryInfo);
       }
       public void DeleteCountry(Countryinfo countryInfo)
       {
           countrydao.DeleteCountryByCountryID(countryInfo);
       }
    }
}
