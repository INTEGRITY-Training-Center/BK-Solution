using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ygMerceInfo
{
    public class RegisterInfo
    {
        public string RegisterID { get; set; }
        public string UserName { get; set; }
        public string NRC { get; set; }
        public DateTime DOB { get; set; }
        public byte[] Picture { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
