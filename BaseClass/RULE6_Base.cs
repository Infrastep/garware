using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class RULE6_Base
    {
        public int RULE6ID { get; set; }
        public Nullable<short> EARN_DEDN_CODE { get; set; }
        public Nullable<short> EMPL_CLASS { get; set; }
        public Nullable<System.DateTime> RULE_WEF_DATE { get; set; }
        public string RANK_CODE { get; set; }
        public string CERT_CODE { get; set; }
        public string FIXED_PRCNT_FLAG { get; set; }
        public Nullable<short> SECONDARY_EARN_DEDN_CODE { get; set; }
        public Nullable<decimal> EARN_DEDN_RATE { get; set; }
        public string ADD_BY { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public string EDIT_BY { get; set; }
        public Nullable<System.DateTime> EDIT_TIME { get; set; }
    }
}
