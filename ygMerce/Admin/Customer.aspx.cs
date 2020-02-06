using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceController;
using ygMerceInfo;

namespace ygMerce
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                QuarterController quarCtlr = new QuarterController();
                List<Quarterinfo> quarLst = new List<Quarterinfo>();
                quarLst = quarCtlr.SelectAllQuarterinfo();
                CustomerAddress.DataSource = quarLst;
                CustomerAddress.DataBind();

                TownshipController townshipCtlr = new TownshipController();
                List<TownshipInfo> townshipLst = new List<TownshipInfo>();
                townshipLst = townshipCtlr.SelectAllTownshipInfo();
                townshipData.DataSource = townshipLst;
                townshipData.DataBind();


                SelectAllCustomer();
            }
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Customercontroller custCtlr = new Customercontroller();
            Customerinfo custInfo = new Customerinfo();

            custInfo.CustomerCode = txtCustomerCode.Text;
            custInfo.Name = txtCustomerName.Text;
            custInfo.TownshipID = townshipData.SelectedValue;
            custInfo.Contact = int.Parse(txtContact.Text);
            custInfo.address = CustomerAddress.SelectedValue;

            custCtlr.InsertCustomer(custInfo);
            SelectAllCustomer();
        }
        void SelectAllCustomer()
        {
            Customercontroller custCtl = new Customercontroller();
            List<Customerinfo> custLst = new List<Customerinfo>();
            custLst = custCtl.selectallcustomerinfo();

            CustomerGv.DataSource = custLst;
            CustomerGv.DataBind();
        }
    }
}