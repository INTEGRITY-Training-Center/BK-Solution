using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;
namespace ygMerceDAO
{
    public class TownshipDAO
    {
        public List<TownshipInfo> SelectAllTownshipInfo()
        {
            try
            {
                List<TownshipInfo> lstTownshipInfo = new List<TownshipInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    var hp = (from t in db.Townships select t).ToList();

                    foreach (var one in hp)
                    {
                        TownshipInfo tObj = new TownshipInfo();
                        tObj.TownshipID = one.TownshipID;
                        tObj.TownshipName = one.Township_Name;
                        tObj.TownshipDescription = one.Township_Description;
                        tObj.CityID = one.CityID;


                        lstTownshipInfo.Add(tObj);
                    }

                    return lstTownshipInfo;
                }
            }
            catch (Exception ex)
            {
                return new List<TownshipInfo>();
            }
        }

        public void UpdateTownshipByTownshipID(TownshipInfo TownInfo)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Townships where a.TownshipID == TownInfo.TownshipID select a).First();
                    obj.TownshipID = TownInfo.TownshipID;
                    obj.Township_Name = TownInfo.TownshipName;
                    obj.Township_Description = TownInfo.TownshipDescription;
                    obj.CityID = TownInfo.CityID;
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                Township tbl = new Township();
            }
        }

        public void DeleteTownshipByTownshipID(TownshipInfo TownInfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Townships where a.TownshipID == TownInfo.TownshipID select a).First();
                    db.Townships.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Township tbl = new Township();
            }
        }
    }
}
