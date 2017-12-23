using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class CATEGORY_Base
    {
       public CATEGORY_Base()
        {
            this.CLASSes = new HashSet<CLASS_Base>();
            this.DUTY_TYPE_MASTER = new HashSet<DUTY_TYPE_MASTER_Base>();
        }
    
        public int CATEGORY_ID { get; set; }
        public string CATEGORY_NAME { get; set; }
        public string CATEGORY_CODE { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<CLASS_Base> CLASSes { get; set; }
        public virtual ICollection<DUTY_TYPE_MASTER_Base> DUTY_TYPE_MASTER { get; set; }
    }
}
