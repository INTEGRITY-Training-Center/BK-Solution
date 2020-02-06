using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO.DBML;

namespace ygMerceDAO
{
    public class Persondao
    {
        public List<PersonInfo> selectallPersoninfo()
        {
            try
            {
                List<PersonInfo> lstpinfo = new List<PersonInfo>();
                using (RMSDataContext db = new RMSDataContext())
                {
                    PersonInfo pinfo;
                    var a = (from o in db.Persons select o).ToList();
                    foreach(var obj in a)
                    {
                        pinfo = new PersonInfo();
                        pinfo.PersonID = obj.PersonID;
                        pinfo.Person_Father_Name = obj.Person_Father_s_Name;
                        pinfo.Person_NRC = obj.Person_NRC;
                        pinfo.Street_Address = obj.Street_Address;
                        pinfo.QuarterID = obj.QuarterID;
                        lstpinfo.Add(pinfo);
                    }
                    return lstpinfo;
                }
            }
            catch(Exception ex)
            {
                return new List<PersonInfo>();
            }
        }

        public void InsertPerson(PersonInfo prinfo)
        {
            using (RMSDataContext db = new RMSDataContext())
            {
                Person p = new Person();
                p.PersonID = prinfo.PersonID;
                p.Person_Father_s_Name = prinfo.Person_Father_Name;
                p.Person_NRC = prinfo.Person_NRC;
                p.Street_Address = prinfo.Street_Address;
                p.QuarterID = prinfo.QuarterID;

                db.Persons.InsertOnSubmit(p);
                db.SubmitChanges();
            }
        }
        public void personupdateupdateid(PersonInfo personid)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.Persons where o.PersonID == personid.PersonID select o).First();
                    obj.PersonID = personid.PersonID;
                    obj.Person_NRC = personid.Person_NRC;
                    obj.Person_Father_s_Name = personid.Person_Father_Name;
                    obj.QuarterID = personid.QuarterID;
                    obj.QuarterID = personid.QuarterID;
                    db.SubmitChanges();
                }

            }
            catch(Exception ex)
            {
                PersonInfo person = new PersonInfo();
            }
        }
        public void deletepersonid(PersonInfo deleteperson)
        {
            try
            {
                using (RMSDataContext db = new RMSDataContext())
                {
                    var obj = (from o in db.Persons where o.PersonID == deleteperson.PersonID select o).First();
                    db.Persons.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                }
            }
            catch(Exception ex)
            {
                PersonInfo person = new PersonInfo();
            }
        }
    }
}
