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
    public partial class CategoryForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gridviewcall();
        }
        protected void btnSaveCategory_Click(object sender,EventArgs e)
        {
            Categoryinfo cainfo = new Categoryinfo();
            cainfo.Description = txtDescription.Text;
            cainfo.Type = txtType.Text;
            CategoryController cController = new CategoryController();
            cController.InsertCategory(cainfo);
            gridviewcall();

        }
        public void gridviewcall()
        {
            CategoryController caControl = new CategoryController();
            List<Categoryinfo> lsCat = new List<Categoryinfo>();
            lsCat = caControl.SelectAllCategoryInfo();
            gVCategory.DataSource = lsCat;
            gVCategory.DataBind();
        }
    }
}