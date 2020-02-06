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
    public partial class State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }


        protected void btnSaveState_Click(object sender, EventArgs e)
        {
            StateInfo Stinfo = new StateInfo();
            Stinfo.DivisionName = txtDivisionName.Text;
            Stinfo.DivisionDescription = txtDivisionDescription.Text;
            Stinfo.CountryID = txtCountryID.Text;
         //
            StateController StateController = new StateController();
           StateController.InsertState(Stinfo);
            gridviewcall();


        }


        public void gridviewcall()
        {

            State StateControl = new State();
            List<StateInfo> lsSt = new List<StateInfo>();
            lsSt = StateControl.SelectAllStateInfo();
            GridView1.DataSource = lsSt;
            GridView1.DataBind();

        }

        private List<StateInfo> SelectAllStateInfo()
        {
            throw new NotImplementedException();
        }
    }
}