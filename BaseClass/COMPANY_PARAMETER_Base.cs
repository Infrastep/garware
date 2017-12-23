using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class COMPANY_PARAMETER_Base
    {
       public COMPANY_PARAMETER_Base()
        {
            this.ADDRESSEE_MASTER = new HashSet<ADDRESSEE_MASTER_Base>();
            this.COMPANY_BRANCH = new HashSet<COMPANY_BRANCH_Base>();
        }
    
        public int COMPANYID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string PHONE { get; set; }
        public string FAX_NO { get; set; }
        public string EMAIL { get; set; }
        public string SERVICE_TAX_NO { get; set; }
        public string PAN_NO { get; set; }
        public string COMPANY_LOGO { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<ADDRESSEE_MASTER_Base> ADDRESSEE_MASTER { get; set; }
        public virtual ICollection<COMPANY_BRANCH_Base> COMPANY_BRANCH { get; set; }
    }
}
