using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class RELIGION_Base
    {
       public RELIGION_Base()
        {
            this.EMP_FIXED = new HashSet<EMP_FIXED_Base>();
        }
    
        public int RELIGIONID { get; set; }
        public string RELIGION_NAME { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<EMP_FIXED_Base> EMP_FIXED { get; set; }
    }
}
