using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class DOCUMENTS_TYPE_Base
    {
       public DOCUMENTS_TYPE_Base()
        {
            this.DOCUMENTS_MASTER = new HashSet<DOCUMENTS_MASTER_Base>();
        }
    
        public int DTID { get; set; }
        public string DTNAME { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<DOCUMENTS_MASTER_Base> DOCUMENTS_MASTER { get; set; }
    }
}
