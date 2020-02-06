using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class TownshipController
    {
        TownshipInfo townInfo = new TownshipInfo();
        TownshipDAO townDao = new TownshipDAO();
        public List<TownshipInfo> SelectAllTownshipInfo()
        {
            List<TownshipInfo> lstTownship = new List<TownshipInfo>();
            lstTownship = townDao.SelectAllTownshipInfo();
            return lstTownship;

        }

        public void InsertTownship(TownshipInfo TownInfo)
        {
            
        }

        public void UpdateTownship(TownshipInfo TownInfo)
        {
            townDao.UpdateTownshipByTownshipID(TownInfo);
        }

        public void DeleteTownship(TownshipInfo TownInfo)
        {
            townDao.UpdateTownshipByTownshipID(TownInfo);
        }
    }
}
