using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class CLASS_Base
    {
       public CLASS_Base()
        {
            this.RANK_CLASS = new HashSet<RANK_CLASS_Base>();
        }

       public int CLASSID { get; set; }
       public string CLASS_NAME { get; set; }
       public Nullable<bool> ACTIVE { get; set; }

       public string CLASS_TYPE { get; set; }
       public Nullable<bool> COST_TO_COMP { get; set; }

       public virtual ICollection<RANK_CLASS_Base> RANK_CLASS { get; set; }
    }
}
