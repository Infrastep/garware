using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class PERSONNEL_MASTER_Base
    {
       public PERSONNEL_MASTER_Base()
        {
            this.EMPLOYEE_STATUS = new HashSet<EMPLOYEE_STATUS_Base>();
        }
    
        public int PERSONNELID { get; set; }
        public string NAME { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.Guid> ASP_USER_DETAILS { get; set; }

        public virtual ICollection<EMPLOYEE_STATUS_Base> EMPLOYEE_STATUS { get; set; }
    }
}
