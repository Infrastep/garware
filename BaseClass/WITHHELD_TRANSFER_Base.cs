using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class WITHHELD_TRANSFER_Base
   {
       public long WITHHELD_TRANSFER_ID { get; set; }
       public string YR { get; set; }
       public string MON { get; set; }
       public Nullable<int> EMP_CODE { get; set; }
       public Nullable<decimal> TRANS_AMT { get; set; }
       public Nullable<int> AGREEMENT_CODE { get; set; }

       public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
