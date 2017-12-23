using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class CERTIFICATE_TYPE_MASTER_Base
    {
        public CERTIFICATE_TYPE_MASTER_Base()
        {
            this.CERTIFICATE_MASTER = new HashSet<CERTIFICATE_MASTER_Base>();
        }
    
        public int CTID { get; set; }
        public string CT_DESC { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual ICollection<CERTIFICATE_MASTER_Base> CERTIFICATE_MASTER { get; set; }
    }
}
