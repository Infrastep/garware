using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class RELATIONSHIP_MASTER_Base
    {
       public RELATIONSHIP_MASTER_Base()
        {
            this.KIN_DETAILS = new HashSet<KIN_DETAILS_Base>();
        }
    
        public int RELATIONSHIPID { get; set; }
        public string RELATION { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<KIN_DETAILS_Base> KIN_DETAILS { get; set; }
    }
}
