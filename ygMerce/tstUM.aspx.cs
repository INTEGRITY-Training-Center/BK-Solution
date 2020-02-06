using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel;
using System.IO;
using ygMerceInfo;
using ygMerceController;
using System.Data;

namespace ygMerce
{
    public partial class tstUM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UnitOfMeasureInfo sinfo = new UnitOfMeasureInfo();
            UnitOfMeasureController sCon = new UnitOfMeasureController();
            string fn = @"D:\UMList.xlsx";

            FileStream fs = File.Open(fn, FileMode.Open, FileAccess.Read);

            IExcelDataReader ir = ExcelReaderFactory.CreateOpenXmlReader(fs);
            DataSet ds = ir.AsDataSet();

            foreach (DataTable tobj in ds.Tables)
            {
                foreach (DataRow robj in tobj.Rows)
                {
                    sinfo.UMDescription = Convert.ToString(robj[0]);
                    sCon.InsertUnitOfMeasure(sinfo);
                }

            }
            ir.Close();
            fs.Close();
        }
    }
}