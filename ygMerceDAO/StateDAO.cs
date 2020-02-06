using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO.DBML;
using ygMerceInfo;

namespace ygMerceDAO
{
    public class StateDAO
    {
        StateInfo sinfo = new StateInfo();

        public List<StateInfo> SelectAllStateinfo()
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    List<StateInfo> ss = new List<StateInfo>();
                    {
                        StateInfo ssinfo;
                        var s = (from ssi in db.States select ssi).ToList();

                        foreach (var obj in s)
                        {
                            ssinfo = new StateInfo();
                            ssinfo.CountryID = obj.CountryID;
                            ssinfo.DivitionID = obj.State_DivisionID;
                            ssinfo.DivisionDescription = obj.State_Division_Description;
                            ssinfo.DivisionName = obj.State_Division_Name;
                        }
                        return ss;
                    }
                }
            }
            catch (Exception ex)
            {
                return new List<StateInfo>();
            }
        }


        public void UpdateStateByStateID(StateInfo stinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.States where a.State_DivisionID == stinfo.DivitionID select a).First();
                    obj.State_DivisionID = stinfo.DivitionID;
                    obj.State_Division_Name = stinfo.DivisionName;
                    obj.State_Division_Description = stinfo.DivisionDescription;
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                State St = new State();

            }
        }

         public void DeleteStateByStateID(StateInfo Stinfo)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from a in db.States where a.State_DivisionID == Stinfo.DivitionID select a).First();

                    db.States.DeleteOnSubmit(obj);
                    db.SubmitChanges();

                }
            }
            catch (Exception ex)
            {
                State St = new State();

            }
        }
    }
}


