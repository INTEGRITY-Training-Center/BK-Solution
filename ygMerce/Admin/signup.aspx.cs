using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ygMerceInfo;
using ygMerceController;
using System.Web.UI.HtmlControls;

namespace ygMerce.Admin
{
    public partial class signup : System.Web.UI.Page
    {
        CategoryController con = new CategoryController();
        List<Categoryinfo> cin = new List<Categoryinfo>();
        public void initializeControls()
        {
            txtName.Text = string.Empty;
            txtMobileNo.Text = string.Empty;
            txtAddress.Text = string.Empty;
            //txtpw.Text = string.Empty;
            //txtretypepw.Text = string.Empty;
            txtMobileNo.Style.Add("border-color", "#ced4da");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                for (var i = 1; i < TextBoxCount; i++)
                {
                    AddTextBox(i);
                    //AddButton(i);
                }
               
            }

            if(!IsPostBack)
            {
                rptMainList.DataSource = con.SelectCategoryColumn();
                rptcount = con.SelectCategoryColumn().Count();
                rptMainList.DataBind();

            }
            //this.acButton.Disabled = true;
            //addtb();
            //var g = (TextBox)appendtextbox.FindControl("txtDynamic0");
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message","alert('"+ g.ID.ToArray().Count().ToString()+"')", true);
        }

        private int rptcount
        {
            get
            {
                var count = ViewState["rptcount"];
                return (count == null) ? 0 : (int)count;
            }
            set { ViewState["rptcount"] = value; }
        }

        private int TextBoxCount
        {
            get
            {
                var count = ViewState["txtBoxCount"];
                return (count == null) ? 1 : (int)count;
            }
            set { ViewState["txtBoxCount"] = value; }
        }

        private void AddTextBox(int index)
        {
            var txt = new HtmlInputText { ID = string.Concat("txtDynamic", index) };
            txt.Style.Add("display", "block");
            txt.Attributes.Add("class", "form-control col-9 float-left");
            txt.Attributes.Add("runat", "server");
            //var btn = new Button { Text = "Remove" };
            //btn.Click += acButton_ServerClick;

            appendtextbox.Controls.Add(txt);
            AddButton(index);
            AddCloseButton(index);
        }
        private void AddButton(int index)
        {
            var txt = new HtmlAnchor { ID = string.Concat("aButton", index) };
            txt.Style.Add("display", "block");
            txt.Attributes.Add("class", "addtextbox col-1 float-left mr-2");
            //txt.Attributes.Add("onserverclick", "btnAddTextBox_Click");
            txt.HRef = "javascript:__doPostBack('aButton','')";
            
            txt.InnerHtml = "<i class='fas fa-plus-square fa-lg' ></i>";
            //var btn = new Button { Text = "Remove" };
            //btn.Click += acButton_ServerClick;
            appendtextbox.Controls.Add(txt);
        }

        private void AddCloseButton(int index)
        {
            var txt = new LinkButton { ID = string.Concat("acButton", index) };
            txt.Style.Add("display", "block");
            txt.Attributes.Add("class", "addtextbox col-1 float-left");
            //txt.Attributes.Add("onserverclick", "btnRemove_Click");
            //txt.Attributes.Add("CommandArgument", "'<%# Eval(" + txt.ID + ") %>'");
            txt.CommandArgument = txt.ID;
            txt.Command += new CommandEventHandler(btnRemove_Click);
            //txt. = "javascript:__doPostBack('acButton','')";

            txt.Text = "<i class='fas fa-window-close fa-lg' ></i>";
            //var btn = new Button { Text = "Remove" };
            //btn.Click += acButton_ServerClick;
            appendtextbox.Controls.Add(txt);
        }

        void addtb()
        {
            AddTextBox(TextBoxCount);
            //AddButton(TextBoxCount);
            TextBoxCount++;
        }
        protected void btnAddTextBox_Click(object sender, EventArgs e)
        {
            addtb();
        }
        public void btnRemove_Click(object sender, EventArgs e)
        {
            //var a = sender.GetType().ToString();
            var id = ((LinkButton)sender).CommandArgument;
            string s = id.Substring(8);
            var g = (HtmlInputText)appendtextbox.FindControl("txtDynamic" + s);
            var b = (HtmlAnchor)appendtextbox.FindControl("aButton" + s);
            var ac = (LinkButton)appendtextbox.FindControl(id);
            appendtextbox.Controls.Remove(g);
            appendtextbox.Controls.Remove(b);
            appendtextbox.Controls.Remove(ac);
            TextBoxCount--;

            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", "alert('"+ id + "')", true);
            //var btnRemove = sender as Button;
            //if (btnRemove == null) return;
            //btnRemove.Parent.Visible = false;
        }
        
        void removecontrol()
        {
            var t0 = (HtmlInputText)appendtextbox.FindControl("txtDynamic0");
           
            t0.Value = "";
            
            for (int i = 1; i < TextBoxCount; i++)
            {
                //HtmlGenericControl g = new HtmlGenericControl();
                
                var g = (HtmlInputText)appendtextbox.FindControl("txtDynamic" + i.ToString());
                var b = (HtmlAnchor)appendtextbox.FindControl("aButton" + i.ToString());
                var ac = (LinkButton)appendtextbox.FindControl("acButton" + i.ToString());

                appendtextbox.Controls.Remove(g);
                appendtextbox.Controls.Remove(b);
                appendtextbox.Controls.Remove(ac);
            }
            TextBoxCount = 1;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //if(txtpw.Text.Trim() == txtretypepw.Text.Trim())
            //{
                BKCustomerController bcon = new BKCustomerController();
                BKCustomerInfo binfo = new BKCustomerInfo();

                int i = bcon.selectBKCustomerInfoByMobile(txtMobileNo.Text.Trim());
                if (i == 0)

                {
                    binfo.Name = txtName.Text.Trim();
                    binfo.Contact = txtMobileNo.Text.Trim();
                    binfo.address = txtAddress.Text.Trim();
                    //binfo.CustomerPassword = txtpw.Text.Trim();
                    binfo.InsertDate = DateTime.UtcNow.AddMinutes(390);
                    binfo.UpdateDate = DateTime.UtcNow.AddMinutes(390);

                    string statusMsg = bcon.InsertCustomer(binfo);
                    if (!string.IsNullOrEmpty(statusMsg))
                    {
                        string msg = "if (Notification.permission === 'granted') { var notify = new Notification('New Customer' , { body: '" + statusMsg + "',icon: '',} )}" +
                    "else {" +

                   "Notification.requestPermission().then(function (p) {" +
                    "        if (p === 'granted') {" +

                    "            var notify = new Notification('New Customer'+ Msg, {" +
                    "                body: '" + statusMsg + "'," +
                    "                icon: ''," +
                    "            });" +
                    "        } else {" +
                    "            console.log('User blocked notifications.');" +
                    "        }" +
                    "    }).catch(function (err) {" +
                    "        console.error(err);" +
                    "    });" +
                    "};";


                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", msg, true);
                        initializeControls();
                    }
                    else
                    {
                      }

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", @"alert('Mobile No is already used!\n Try another Mobile No')", true);
                    txtMobileNo.Style.Add("border-color", "Orange");

                }
            
            
        }

        protected void Btnconfirm_Click(object sender, EventArgs e)
        {
            CategoryController bcon = new CategoryController();
            List<Categoryinfo> blist = new List<Categoryinfo>();
            Categoryinfo bin;

            List<string> slist = new List<string>();

            for(int i = 0;i < TextBoxCount;i++)
            {
                //HtmlGenericControl g = new HtmlGenericControl();
                var g = (HtmlInputText)appendtextbox.FindControl("txtDynamic" + i.ToString());
                if (!string.IsNullOrEmpty(g.Value))
                {
                    bin = new Categoryinfo();
                    bin.Type = g.Value;
                    blist.Add(bin);
                }

                


            }
            if(blist.Count>0)
            {
                foreach (var obj in blist)
                {
                    bin = new Categoryinfo();
                    bin.Type = obj.Type;
                    bcon.InsertCategory(bin);
                    
                }
                string msg = "if (Notification.permission === 'granted') { var notify = new Notification('New Category Items' , { body: '" + blist.Count + "',icon: '',} )}" +
                    "else {" +

                   "Notification.requestPermission().then(function (p) {" +
                    "        if (p === 'granted') {" +

                    "            var notify = new Notification('New Category Items'+ Msg, {" +
                    "                body: '" + blist.Count + " Category Items Added !'," +
                    "                icon: ''," +
                    "            });" +
                    "        } else {" +
                    "            console.log('User blocked notifications.');" +
                    "        }" +
                    "    }).catch(function (err) {" +
                    "        console.error(err);" +
                    "    });" +
                    "};";


                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", msg, true);
                removecontrol();
                rptMainList.DataSource = con.SelectAllCategoryInfo();
                rptMainList.DataBind();
            }
            removecontrol();


        }

        protected void acButton_ServerClick(object sender, EventArgs e)
        {
            //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message", "alert('Atlease on')", true);
            //this.acButton.Disabled = true;
        }

        protected void addp_ServerClick(object sender, EventArgs e)
        {
            var id = ((LinkButton)sender).CommandArgument;
            string s = id.ToString();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Alert Message",s, true);

            //for (int i = 0; i < rptcount; i++)
            //{
            //    var g = (HtmlAnchor)rptMainList.FindControl("rptMainList_lblpid_" + i.ToString());
            //}
        }
    }
}