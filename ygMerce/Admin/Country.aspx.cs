using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceController;
using ygMerceInfo;
using Excel;
using System.IO;
using System.Data;

namespace ygMerce
{
    public partial class Country : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegionController regionCtlr = new RegionController();
            List<Regioninfo> regionLst = new List<Regioninfo>();
            regionLst = regionCtlr.SelectAllRegioninfo();
            regionData.DataSource = regionLst;
            regionData.DataBind();

            SelectAllCountry();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Countrycontroller countryCtlr = new Countrycontroller();
            Countryinfo countryInfo = new Countryinfo();

            countryInfo.Country_Name = txtCountryName.Text;
            countryInfo.Country_Code = txtCountryCode.Text;
            countryInfo.Country_Description = txtCountryDescription.Text;
            countryInfo.RegionID = regionData.SelectedValue;

            countryCtlr.InsertCountry(countryInfo);

            SelectAllCountry();
        }
        void SelectAllCountry()
        {
            Countrycontroller countryCtlr = new Countrycontroller();
            List<Countryinfo> countryLst = new List<Countryinfo>();

            countryLst = countryCtlr.selectallcountryinfo();
            gvCountry.DataSource = countryLst;
            gvCountry.DataBind();
        }

        protected void fubtn_Click(object sender, EventArgs e)
        {
            string filename = @"D:\cou.xlsx";
            FileStream str = File.Open(filename,FileMode.Open,FileAccess.Read);
            //str = File.Open("E:\\cou.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader ir = ExcelReaderFactory.CreateOpenXmlReader(str);

            System.Data.DataSet ds = ir.AsDataSet();


            Countrycontroller countrycon = new Countrycontroller();
            Countryinfo countryinfo = new Countryinfo();
            List<Countryinfo> countryli = new List<Countryinfo>();

            foreach (DataTable obj in ds.Tables)
            {
                foreach (DataRow robj in obj.Rows)
                {
                    countryinfo = new Countryinfo();

                    countryinfo.Country_Name =Convert.ToString( robj[0]);
                    countryinfo.Country_Code = Convert.ToString(robj[1]);
                    countryinfo.Country_Description = Convert.ToString(robj[0]);
                    countrycon.InsertCountry(countryinfo);
                }
                
            }
            ir.Close();
            str.Close();

            SelectAllCountry();

        }
    }
}