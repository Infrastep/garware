﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class RULE9_Base
    {
        public int RULE9ID { get; set; }
        public Nullable<short> EARN_DEDN_CODE { get; set; }
        public Nullable<short> EMPL_CLASS { get; set; }
        public Nullable<System.DateTime> RULE_WEF_DATE { get; set; }
        public Nullable<short> MIN_NO_OF_DAYS { get; set; }
        public Nullable<short> MAX_NO_OF_DAYS { get; set; }
        public Nullable<short> SECONDARY_EARN_DEDN_CODE { get; set; }
        public Nullable<decimal> EARN_PRCNT { get; set; }
        public string ADD_BY { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public string EDIT_BY { get; set; }
        public Nullable<System.DateTime> EDIT_TIME { get; set; }
    }
}
