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
    public partial class tstBrand : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            brandinfoinfo sinfo = new brandinfoinfo();
            BrandController sCon = new BrandController();
            string fn = @"D:\BrandLst.xlsx";

            FileStream fs = File.Open(fn, FileMode.Open, FileAccess.Read);

            IExcelDataReader ir = ExcelReaderFactory.CreateOpenXmlReader(fs);
            DataSet ds = ir.AsDataSet();

            foreach (DataTable tobj in ds.Tables)
            {
                foreach (DataRow robj in tobj.Rows)
                {
                    //sinfo.BrandID = Convert.ToString(robj[0]);
                    sinfo.BrandName = Convert.ToString(robj[0]);
                    sinfo.Model = Convert.ToString(robj[0]);
                    sinfo.CategoryID = Convert.ToString(robj[1]);
                    sCon.InsertBrandByBrandID(sinfo);
                }

            }
            ir.Close();
            fs.Close();
        }
    }
}