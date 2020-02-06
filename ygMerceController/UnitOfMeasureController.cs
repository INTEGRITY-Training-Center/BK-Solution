using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class UnitOfMeasureController
    {
        UnitOfMeasureInfo uomInfo = new UnitOfMeasureInfo();
        UnitOfMeasureDAO uomDao = new UnitOfMeasureDAO();
        public List<UnitOfMeasureInfo> SelectAllUnitOfMeasureInfo()
        {
            List<UnitOfMeasureInfo> lstUnitOfMeasure = new List<UnitOfMeasureInfo>();
            lstUnitOfMeasure = uomDao.SelectAllUnitOfMeasure();
            return lstUnitOfMeasure;
        }

        public void InsertUnitOfMeasure(UnitOfMeasureInfo UOMInfo)
        {
            uomDao.InsertUM(UOMInfo);   
        }

        public void UpdateUnitOfMeasure(UnitOfMeasureInfo UOMInfo)
        {
            uomDao.UpdateUnitOfMeasureByUnitOfMeasurreID(UOMInfo);
        }

        public void DeleteUnitOfMeasure(UnitOfMeasureInfo UOMInfo)
        {
            uomDao.DeleteUnitOfMeasureByUnitOfMeasurreID(UOMInfo);
        }
    }
}
