using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using ygMerceInfo;
using ygMerceController;
using System.Data;

namespace ygMerce
{
    public partial class testReg : System.Web.UI.Page
    {
        
        RegisterController rcon = new RegisterController();
        protected void Page_Load(object sender, EventArgs e)
        {

         
           if (!IsPostBack)
           {
               bindGridview();
           }
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                return returnImage;
            }
        }

        public void bindGridview()
        {
            List<RegisterInfo> rin = new List<RegisterInfo>();
            rin = rcon.SelectAllRegisterInfo();
            gvRegister.DataSource = rin;
            gvRegister.DataBind();
        }
        protected void btnSaveRegister_Click(object sender, EventArgs e)
        {
            RegisterInfo rinfo = new RegisterInfo();
            rinfo.UserName = txtUserName.Text;
            rinfo.NRC = txtNRC.Text;
            rinfo.DOB =DateTime.Parse( txtDOB.Text);
            rinfo.Address = txtAddress.Text;
            rinfo.Gender = txtGender.Text;
            rinfo.Phone = txtPhone.Text;
            rinfo.Password = txtPassword.Text;
            rinfo.Email = txtEmail.Text;
            rinfo.Picture = fuPicture.FileBytes;
            
            rcon.InsertRegister(rinfo);
            bindGridview();  
        }

        //protected void gvRegister_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        DataRowView dr = (DataRowView)e.Row.DataItem;
        //        string imageUrl = "data:image/jpg;base64," + dr["Picture"];
        //        //string imageUrl = "data:image/jpg;base64," +( e.Row.Cells[0]);
        //        (e.Row.FindControl("Image1") as System.Web.UI.WebControls.Image).ImageUrl = imageUrl;
        //    }
        //}
    }
}