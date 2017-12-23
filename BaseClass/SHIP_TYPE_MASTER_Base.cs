using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class SHIP_TYPE_MASTER_Base
    {
       public SHIP_TYPE_MASTER_Base()
        {
            this.SHIP_MASTER = new HashSet<SHIP_MASTER_Base>();
        }
    
        public int TypeID { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<SHIP_MASTER_Base> SHIP_MASTER { get; set; }
    }
}
