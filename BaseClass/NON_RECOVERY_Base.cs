using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class NON_RECOVERY_Base
    {
        public int ID { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public string REMARKS { get; set; }
        public string AMOUNT { get; set; }
        public string INACTIVE_BY { get; set; }
        public Nullable<System.DateTime> INACTIVE_TIME { get; set; }
        public string INACTIVE_COMPUTER { get; set; }

        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
