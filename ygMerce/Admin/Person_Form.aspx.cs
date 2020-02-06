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
    public partial class Person_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            List<Quarterinfo> listquater = new List<Quarterinfo>();
            QuarterController quacontro = new QuarterController();
            listquater = quacontro.SelectAllQuarterinfo();
            quaterperson.DataSource = listquater;
                        
            quaterperson.DataBind();
            grideviewcall();

           


        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            PersonInfo personin = new PersonInfo();
            PersonController personcon = new PersonController();
            personin.Person_Father_Name = txtfathernameperson.Text;
            personin.Person_NRC = txtpersonnrc.Text;
            personin.Street_Address = txtstreeperson.Text;
            personin.QuarterID = quaterperson.SelectedValue;
            personcon.insertpersoncon(personin);
            grideviewcall();

            


        }
        public void grideviewcall()
        {
            PersonController personcontro = new PersonController();
            List<PersonInfo> listperson = new List<PersonInfo>();
            listperson = personcontro.selectallPersoninfo();
            GridView1.DataSource = listperson;
            GridView1.DataBind();

        }
    }
}