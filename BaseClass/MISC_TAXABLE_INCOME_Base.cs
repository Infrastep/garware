using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class MISC_TAXABLE_INCOME_Base
    {
        public int MISC_TAXABLE_INCOME_ID { get; set; }
        public string FINANCIAL_YEAR { get; set; }
        public Nullable<int> EMP_CODE { get; set; }
        public string NARRATION { get; set; }
        public Nullable<decimal> AMOUNT { get; set; }
        public Nullable<int> INCOME_CODE { get; set; }
        public Nullable<System.DateTime> ENTRY_DATE { get; set; }
        public Nullable<decimal> UTILISED { get; set; }
        public Nullable<decimal> TAX_DED { get; set; }
        public Nullable<decimal> TAX_AMT_DED { get; set; }
        public Nullable<decimal> SCHG_DED { get; set; }
        public Nullable<decimal> CESS_DED { get; set; }
        public Nullable<decimal> HCESS_DED { get; set; }

        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual OTHER_INCOME_Base OTHER_INCOME { get; set; }
    }
}
