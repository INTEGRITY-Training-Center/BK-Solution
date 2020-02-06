using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;


namespace ygMerceController
{
    public class RegisterController
    {
        RegisterInfo Reginfo = new RegisterInfo();
        RegisterDao Regdao = new RegisterDao();

        public List<RegisterInfo> SelectAllRegisterInfo()
        {
            List<RegisterInfo> lstRegister = new List<RegisterInfo>();
            lstRegister = Regdao.SelectallRegisterinfo();
            return lstRegister;
        }


        public void InsertRegister(RegisterInfo Reginfo)
        {
            Regdao.InsertRegister(Reginfo);
        }
        public void UpdateRegister(RegisterInfo Reginfo)
        {
            Regdao.UpdateRegisterByRegisterID(Reginfo);
        }
        public void DeleteRegister(RegisterInfo Reginfo)
        {
            Regdao.DeleteRegisterByRegister(Reginfo);
        }
    }
}
