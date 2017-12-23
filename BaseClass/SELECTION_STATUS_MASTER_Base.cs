using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class SELECTION_STATUS_MASTER_Base
    {
        public SELECTION_STATUS_MASTER_Base()
        {
            this.EMPLOYEE_STATUS = new HashSet<EMPLOYEE_STATUS_Base>();
        }
    
        public int SPID { get; set; }
        public string SPNAME { get; set; }
        public string SPDESCRIPTION { get; set; }

        public virtual ICollection<EMPLOYEE_STATUS_Base> EMPLOYEE_STATUS { get; set; }
    }
}
