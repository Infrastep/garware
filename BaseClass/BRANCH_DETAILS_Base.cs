using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class BRANCH_DETAILS_Base
    {
       public BRANCH_DETAILS_Base()
        {
            this.COMPANY_BRANCH = new HashSet<COMPANY_BRANCH_Base>();
            this.EMP_BRANCH = new HashSet<EMP_BRANCH_Base>();
        }
    
        public int BRANCHID { get; set; }
        public string IFSCCODE { get; set; }
        public string SWIFTCODE { get; set; }
        public string MICRCODE { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string PIN { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
        public Nullable<int> BANKID { get; set; }

        public virtual BANK_MASTER_Base BANK_MASTER { get; set; }
        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
        public virtual ICollection<COMPANY_BRANCH_Base> COMPANY_BRANCH { get; set; }
        public virtual ICollection<EMP_BRANCH_Base> EMP_BRANCH { get; set; }
    }
}
