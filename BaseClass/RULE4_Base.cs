using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class RULE4_Base
   {
       public int RULE4ID { get; set; }
       public Nullable<short> EARN_DEDN_CODE { get; set; }
       public Nullable<short> EMPL_CLASS { get; set; }
       public Nullable<System.DateTime> RULE_WEF_DATE { get; set; }
       public Nullable<decimal> MIN_SECONDARY_EARN_AMT { get; set; }
       public Nullable<decimal> MAX_SECONDARY_EARN_AMT { get; set; }
       public string FIXED_PRCNT_OTRATE_FLAG { get; set; }
       public Nullable<short> SECONDARY_EARN_DEDN_CODE { get; set; }
       public Nullable<decimal> EARN_DEDN_RATE { get; set; }
       public string ADD_BY { get; set; }
       public Nullable<System.DateTime> ADD_TIME { get; set; }
       public string EDIT_BY { get; set; }
       public Nullable<System.DateTime> EDIT_TIME { get; set; }
       public int XX { get; set; }
    }
}
