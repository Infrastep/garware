using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class WITHHELD_REFUND_Base
   {
       public int ID { get; set; }
       public int EMP_CODE { get; set; }
       public string REMARKS { get; set; }
       public string AMOUNT { get; set; }
       public string FINANCIAL_YEAR { get; set; }
       public string REF_PREFIX { get; set; }
       public Nullable<int> REF_NO { get; set; }
       public Nullable<System.DateTime> REF_DATE { get; set; }

       public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
