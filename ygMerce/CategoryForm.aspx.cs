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
    public partial class CategoryForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Categoryinfo caInfo = new Categoryinfo();
            CategoryController caCon = new CategoryController();
            string fn = @"E:\CategoryList.xlsx";

            FileStream fs = File.Open(fn, FileMode.Open, FileAccess.Read);

            IExcelDataReader ir = ExcelReaderFactory.CreateOpenXmlReader(fs);
            DataSet ds = ir.AsDataSet();

            foreach (DataTable tobj in ds.Tables)
            {
                foreach (DataRow robj in tobj.Rows)
                {
                    caInfo.Type = Convert.ToString(robj[0]);
                    caInfo.Description = Convert.ToString(robj[1]);

                    caCon.InsertCategory(caInfo);
                }

            }
            ir.Close();
            fs.Close();
        }
    }
}