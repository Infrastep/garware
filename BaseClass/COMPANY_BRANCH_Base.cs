using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class COMPANY_BRANCH_Base
    {
       public int CBID { get; set; }
        public Nullable<int> BRANCHID { get; set; }
        public Nullable<int> COMPANYID { get; set; }
        public string CHEQUE_NAME { get; set; }
    
        public virtual BRANCH_DETAILS_Base BRANCH_DETAILS { get; set; }
        public virtual COMPANY_PARAMETER_Base COMPANY_PARAMETER { get; set; }
    }
}
