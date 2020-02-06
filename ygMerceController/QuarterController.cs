using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class QuarterController
    {
        Quarterinfo qinfo;
        QuarterDao qdao = new QuarterDao();
        List<Quarterinfo> lstQuarter;
        public List<Quarterinfo> SelectAllQuarterinfo()
        {
            lstQuarter = new List<Quarterinfo>();
            lstQuarter = qdao.SelectallQuarterinfo();
            return lstQuarter;
        }
        public void InsertQuarter(Quarterinfo quinfo)
        {
            qdao.InsertQuarter(quinfo);
        }
        public void UpdateQuarter(Quarterinfo quinfo)
        {
            qdao.UpdateQuarterByQuaterId(quinfo);
        }
        public void DelectQuarter(Quarterinfo quinfo)
        {
            qdao.DelectQuarterByQuaterId(quinfo);
        }
    }
}
