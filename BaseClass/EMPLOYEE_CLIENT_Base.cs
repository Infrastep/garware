using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class EMPLOYEE_CLIENT_Base
    {
        public long EMPCLINTID { get; set; }
        public Nullable<int> EMP_ID { get; set; }
        public Nullable<int> SHIP_ID { get; set; }
        public Nullable<int> RANK_CLASS_ID { get; set; }
        public Nullable<System.DateTime> STARTDATE { get; set; }
        public Nullable<System.DateTime> ENDDATE { get; set; }
        public Nullable<int> STATUS { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual RANK_CLASS_Base RANK_CLASS { get; set; }
        public virtual SHIP_MASTER_Base SHIP_MASTER { get; set; }

    }
}
