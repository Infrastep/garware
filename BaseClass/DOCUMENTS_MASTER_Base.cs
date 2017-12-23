using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class DOCUMENTS_MASTER_Base
    {
        public int DMID { get; set; }
        public string DMCODE { get; set; }
        public string DMDESCRIPTION { get; set; }
        public string PATH { get; set; }
        public Nullable<int> EMP_ID { get; set; }
        public Nullable<System.DateTime> LAST_MODIFY { get; set; }
        public Nullable<System.DateTime> VALIDITY { get; set; }
        public Nullable<int> DT_ID { get; set; }
      
        public Nullable<System.DateTime> ISSUE_DATE { get; set; }
        public Nullable<int> ISSUE_PLACE { get; set; }

        public Nullable<int> MED_TYPE { get; set; }

        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }

        public virtual DOCUMENTS_TYPE_Base DOCUMENTS_TYPE { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
