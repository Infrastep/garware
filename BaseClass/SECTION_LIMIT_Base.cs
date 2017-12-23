using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class SECTION_LIMIT_Base
    {
       public SECTION_LIMIT_Base()
        {
            this.TAX_CODE = new HashSet<TAX_CODE_Base>();
        }
    
        public int ID { get; set; }
        public string SECTION { get; set; }
        public Nullable<decimal> MAX_LIMIT { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<TAX_CODE_Base> TAX_CODE { get; set; }
    }
}
