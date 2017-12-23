using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class EMP_BRANCH_Base
    {
        public int EBID { get; set; }
        public Nullable<int> BRANCHID { get; set; }
        public Nullable<int> EMPID { get; set; }
        public string BANK_AC_NO_NRE { get; set; }
        public string BANK_NAME_NRE { get; set; }
        public string BANK_ADDRESS_NRE { get; set; }
        public string CHEQUE_NAME { get; set; }
        public string IFSC_CODE_NRE { get; set; }
        public Nullable<bool> NOT_PF { get; set; }

        public virtual BRANCH_DETAILS_Base BRANCH_DETAILS { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
