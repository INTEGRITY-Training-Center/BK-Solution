using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;



namespace ygMerceDAO
{
    public class QuarterDao
    {
        public List<Quarterinfo> SelectallQuarterinfo()
        {
            try
            {
                List<Quarterinfo> lstinfo = new List<Quarterinfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    Quarterinfo qinfo;
                    var a = (from o in db.Quarters select o).ToList();
                    foreach (var obj in a)
                    {
                        qinfo = new Quarterinfo();
                        qinfo.QuarterID = obj.QuarterID;
                        qinfo.QuarterName = obj.Quarter_Name;
                        qinfo.QuarterDescription = obj.Quarter_Description;
                        qinfo.TownshipID = obj.TownshipID;
                        lstinfo.Add(qinfo);

                    }
                    return lstinfo;
                }

            }
            catch (Exception ex)
            {
                return new List<Quarterinfo>();
            }
        }

        public void InsertQuarter(Quarterinfo qinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                Quarter tbl = new Quarter();
                tbl.QuarterID = qinfo.QuarterID;
                tbl.Quarter_Description = qinfo.QuarterDescription;
                tbl.Quarter_Name = qinfo.QuarterName;
                tbl.TownshipID = qinfo.TownshipID;
                db.Quarters.InsertOnSubmit(tbl);
                db.SubmitChanges();
            }
        }

        public void UpdateQuarterByQuaterId(Quarterinfo qu)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var qua = (from q in db.Quarters where q.QuarterID == qu.QuarterID select q).First();

                    qua.QuarterID = qu.QuarterID;
                    qua.Quarter_Description = qu.QuarterDescription;
                    qua.Quarter_Name = qu.QuarterName;
                    qua.TownshipID = qu.TownshipID;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Quarterinfo qq = new Quarterinfo();
            }
        }

        public void DelectQuarterByQuaterId(Quarterinfo qu)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var qua = (from q in db.Quarters where q.QuarterID == qu.QuarterID select q).First();

                    db.Quarters.DeleteOnSubmit(qua);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                Quarterinfo qq = new Quarterinfo();
            }
        }
    }
}
