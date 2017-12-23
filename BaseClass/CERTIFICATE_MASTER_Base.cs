using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class CERTIFICATE_MASTER_Base
    {
        public int CERTID { get; set; }
        public string CERT_DESC { get; set; }
        public string PATH { get; set; }
        public Nullable<int> EMP_ID { get; set; }
        public Nullable<System.DateTime> LAST_MODIFY { get; set; }
        public Nullable<System.DateTime> VALIDITY { get; set; }
        public Nullable<int> ISSUE_PLACE { get; set; }
        public Nullable<int> CTID { get; set; }
       
        public virtual CERTIFICATE_TYPE_MASTER_Base CERTIFICATE_TYPE_MASTER { get; set; }
        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
