using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;


namespace ygMerceDAO
{
    public class RegionDao
    {
        public List<Regioninfo> SelectallRegioninfo()
        {
            try
            {
                List<Regioninfo> lstinfo = new List<Regioninfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    Regioninfo rinfo;
                    var a = (from o in db.Regions select o).ToList();
                    foreach (var obj in a)
                    {
                        rinfo = new Regioninfo();
                        rinfo.RegionID = obj.RegionID;
                        rinfo.Region_Name = obj.Region_Name;
                        rinfo.Region_Description = obj.Region_Description;
                        lstinfo.Add(rinfo);

                    }
                    return lstinfo;
                }

            }
            catch (Exception ex)
            {
                return new List<Regioninfo>();
            }
        }


        public void UpdateRegionByRegionID(Regioninfo regioninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Regions where a.RegionID == regioninfo.RegionID select a).First();
                    obj.RegionID = regioninfo.RegionID;
                    obj.Region_Name = regioninfo.Region_Name;
                    obj.Region_Description = regioninfo.Region_Description;
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Region Region = new Region();
            }
        }

        public void DeleteRegioinByRegionID(Regioninfo regioninfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.Regions where a.RegionID == regioninfo.RegionID select a).First();
                    db.Regions.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Region Region = new Region();
            }
        }

    }
}
