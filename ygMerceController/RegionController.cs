using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;

namespace ygMerceController
{
    public class RegionController
    {
        Regioninfo Reginfo = new Regioninfo();
        RegionDao Regdao = new RegionDao();
        public List<Regioninfo> SelectAllRegioninfo()
        {
            List<Regioninfo> lstRegion = new List<Regioninfo>();
            lstRegion = Regdao.SelectallRegioninfo();
            return lstRegion;
        }

        public void InsertRegion(Regioninfo Regioninfo)
        {
           // Regdao.InsertRegion(Regioninfo);
        }
        public void UpdateRegion(Regioninfo Regioninfo)
        {
            Regdao.UpdateRegionByRegionID(Regioninfo);
        }
        public void DeleteRegion(Regioninfo Regioninfo)
        {
            Regdao.DeleteRegioinByRegionID(Regioninfo);
        }
    }
}
