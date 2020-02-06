using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceDAO;
using ygMerceInfo;
namespace ygMerceController
{
    public class ReorderController
    {
        ReorderInfo Reoinfo = new ReorderInfo();
        ReorderDao Reodao = new ReorderDao();

        public List<ReorderInfo> SelectAllReorderInfo()
        {
            List<ReorderInfo> lstReorder = new List<ReorderInfo>();
            lstReorder = Reodao.SelectallReorderinfo();
            return lstReorder;
        }

        public void InsertReorder(ReorderInfo Reoinfo)
        {
            Reodao.InsertReorder(Reoinfo);
        }

        public void UpdateReorder(ReorderInfo Reoinfo)
        {
            Reodao.UpdateReorderByReorderID(Reoinfo);
        }
        public void DeleteReorder(ReorderInfo Reoinfo)
        {
            Reodao.DeleteReorderByReorderID(Reoinfo);
        }
    }
}
