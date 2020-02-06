using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceInfo;
using ygMerceController;

namespace ygMerce
{
    public partial class Register : System.Web.UI.Page
    {
        
            protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }

        protected void btnSaveRegister_Click(object sender,EventArgs e){
            RegisterInfo Regsinfo = new RegisterInfo();
            //Stinfo.StateID = txtRegionID.Text;
           // Regsinfo.RegisterID = txtRegisterID.Text;
            Regsinfo.UserName = txtUserName.Text;
            Regsinfo.NRC = txtNRC.Text;
            Regsinfo.DOB =Convert.ToDateTime(txtDOB.Text);
            //Regsinfo.Picture = txtPicture.Text;
            Regsinfo.Address = txtAddress.Text;
            Regsinfo.Gender = txtGender.Text;
            Regsinfo.Phone = txtPhone.Text;
            Regsinfo.Password = txtPassword.Text;
            Regsinfo.Email = txtEmail.Text;
            Regsinfo.InsertDate = Convert.ToDateTime(txtInsertDate.Text);
            Regsinfo.UpdateDate = Convert.ToDateTime(txtUpdateDate.Text);



           //asked text box

            RegisterController RegiController = new RegisterController();
            RegiController.InsertRegister(Regsinfo);
            gridviewcall();


        }

       
        public void gridviewcall()
        {

           RegisterController RegsControl = new RegisterController();
           List<RegisterInfo> lsRegs = new List<RegisterInfo>();
           lsRegs= RegsControl.SelectAllRegisterInfo();
           GridView1.DataSource = lsRegs;
            GridView1.DataBind();
   
        }
        
    }
}