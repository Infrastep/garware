using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class EMPLOYEE_STATUS_Base
    {
        public long EMPSTATID { get; set; }
        public Nullable<int> EMP_ID { get; set; }
        public Nullable<int> STATUS_ID { get; set; }
        public Nullable<System.DateTime> UPDATE_DATE { get; set; }
        public Nullable<int> UPDATE_PERSONEL { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public string REMARKS { get; set; }
        
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED1 { get; set; }
        public virtual SELECTION_STATUS_MASTER_Base SELECTION_STATUS_MASTER { get; set; }

    }
}
