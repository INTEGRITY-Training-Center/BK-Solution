using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ygMerceInfo;
using ygMerceDAO;

namespace ygMerceController
{
    public class PersonController
    {
        PersonInfo pinfo;
        Persondao pdao = new Persondao();
        List<PersonInfo> lper ;

        public List<PersonInfo> selectallPersoninfo()
        {
            lper = new List<PersonInfo>();
            lper = pdao.selectallPersoninfo();
            return lper;
        }
        public void insertpersoncon(PersonInfo insertperson)
        {
            pdao.InsertPerson(insertperson);

        }
    }
}
