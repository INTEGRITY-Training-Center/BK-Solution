using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;


namespace ygMerceController
{
    public class StateController
    {
        StateInfo Stinfo = new StateInfo();
        StateDAO Stdao = new StateDAO();

        public List<StateInfo> SelectAllStateInfo()
        {
            List<StateInfo> lstState = new List<StateInfo>();
            lstState = Stdao.SelectAllStateinfo();
            return lstState;
        }

        public void InsertState(StateInfo Stinfo)
        {
               }
        public void UpdateState(StateInfo Stinfo)
        {
            Stdao.UpdateStateByStateID(Stinfo);
        }
        public void DeleteRegion(StateInfo Stinfo)
        {
            Stdao.DeleteStateByStateID(Stinfo);
        }
    }
}
