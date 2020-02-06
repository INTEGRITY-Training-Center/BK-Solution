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
    public partial class tstSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SupplierInfo sinfo = new SupplierInfo();
            SupplierController sCon = new SupplierController();
            string fn = @"D:\SupplierList.xlsx";

            FileStream fs = File.Open(fn, FileMode.Open, FileAccess.Read);

            IExcelDataReader ir = ExcelReaderFactory.CreateOpenXmlReader(fs);
            DataSet ds = ir.AsDataSet();

            foreach (DataTable tobj in ds.Tables)
            {
                foreach (DataRow robj in tobj.Rows)
                {
                    sinfo.SupplierName = Convert.ToString(robj[0]);
                    sinfo.SupplierEmail = Convert.ToString(robj[1]);
                    sinfo.SupplierPhoneNo = Convert.ToString(robj[2]);
                    sinfo.SupplierAddress = Convert.ToString(robj[3]);
                    sCon.InsertSupplier(sinfo);
                }

            }
            ir.Close();
            fs.Close();
        }
    }
}