using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;
namespace ygMerceDAO
{
    public class UnitOfMeasureDAO
    {
        public void InsertUM(UnitOfMeasureInfo umf)
        {

            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    UnitOfMeasure um = new UnitOfMeasure();
                    Guid uid = Guid.NewGuid();
                    um.UMID = uid.ToString();
                    um.UMDescription = umf.UMDescription;

                    db.UnitOfMeasures.InsertOnSubmit(um);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {

            }
 
        }

        public List<UnitOfMeasureInfo> SelectAllUnitOfMeasure()
        {
            try
            {
                List<UnitOfMeasureInfo> lstUnitOfMeasure = new List<UnitOfMeasureInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    var hp = (from u in db.UnitOfMeasures select u).ToList();

                    foreach (var one in hp)
                    {
                        UnitOfMeasureInfo uObj = new UnitOfMeasureInfo();
                        uObj.UMID = one.UMID;
                        uObj.UMDescription = one.UMDescription;
                        lstUnitOfMeasure.Add(uObj);
                    }

                    return lstUnitOfMeasure;
                }
            }
            catch (Exception ex)
            {
                return new List<UnitOfMeasureInfo>();
            }
        }

        public void UpdateUnitOfMeasureByUnitOfMeasurreID(UnitOfMeasureInfo UOMInfo)
        {
            try
            {

                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.UnitOfMeasures where a.UMID == UOMInfo.UMID select a).First();
                    obj.UMID = UOMInfo.UMID;
                    obj.UMDescription = UOMInfo.UMDescription;
                    db.SubmitChanges();

                }
            }
            catch(Exception ex)
            {
                UnitOfMeasure tbl = new UnitOfMeasure();
            }

        }

        public void DeleteUnitOfMeasureByUnitOfMeasurreID(UnitOfMeasureInfo UOMInfo)
        {
            try
            {


                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.UnitOfMeasures where a.UMID == UOMInfo.UMID select a).First();
                    db.UnitOfMeasures.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }

            }
            catch (Exception ex)
            {
                UnitOfMeasure tbl = new UnitOfMeasure();
            }
        }
    }
}
