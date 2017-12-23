using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class RULE8_Base
    {
        public int RULE8ID { get; set; }
        public Nullable<short> EARN_DEDN_CODE { get; set; }
        public Nullable<short> EMPL_CLASS { get; set; }
        public Nullable<System.DateTime> RULE_WEF_DATE { get; set; }
        public string SHIP_CODE { get; set; }
        public Nullable<short> PROLONG_FROM_MONTH { get; set; }
        public Nullable<short> PROLONG_TO_MONTH { get; set; }
        public Nullable<decimal> PRCNT_IN_FIRST_PERIOD { get; set; }
        public Nullable<decimal> PRCNT_IN_SECOND_PERIOD { get; set; }
        public Nullable<decimal> PRCNT_IN_THIRD_PERIOD { get; set; }
        public Nullable<short> SECONDARY_EARN_DEDN_CODE { get; set; }
        public string ADD_BY { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public string EDIT_BY { get; set; }
        public Nullable<System.DateTime> EDIT_TIME { get; set; }
    }
}
