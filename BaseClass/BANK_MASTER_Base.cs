using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class BANK_MASTER_Base
    {
       public BANK_MASTER_Base()
        {
            this.BRANCH_DETAILS = new HashSet<BRANCH_DETAILS_Base>();
        }

       public int BANKID { get; set; }
       public string BANK_NAME { get; set; }
       public Nullable<bool> ACTIVE_BANK { get; set; }
       public string BANK_CODE { get; set; }
       public string ADD_BY { get; set; }
       public string EDIT_BY { get; set; }
       public Nullable<System.DateTime> ADD_TIME { get; set; }
       public Nullable<System.DateTime> EDIT_TIME { get; set; }
       public Nullable<bool> STATUS { get; set; }

       public virtual ICollection<BRANCH_DETAILS_Base> BRANCH_DETAILS { get; set; }
    }
}
