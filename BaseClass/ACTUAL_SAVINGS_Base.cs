﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class ACTUAL_SAVINGS_Base
    {
        public int ACTUAL_SAVINGS_ID { get; set; }
        public string FINANCIAL_YEAR { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public Nullable<int> TYPE { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<System.DateTime> SAVINGS_DATE { get; set; }
        public string CERTIFICATE_NO { get; set; }
        public Nullable<int> NO_MONTHS { get; set; }
        public Nullable<System.DateTime> AUTH_DATE { get; set; }
        public string AUTH_BY { get; set; }
        public Nullable<System.DateTime> AUTH_TIME { get; set; }
        public string AUTH_COMPUTER { get; set; }
        public Nullable<int> AGREEMENT_CODE { get; set; }

        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual TAX_CODE_Base TAX_CODE { get; set; }
        public virtual AGREEMENT_DETAILS_Base AGREEMENT_DETAILS { get; set; }
    }
}
