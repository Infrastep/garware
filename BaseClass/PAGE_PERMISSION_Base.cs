using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class PAGE_PERMISSION_Base
    {
        public int PAGEPERMISSIONID { get; set; }
        public Nullable<int> PAGEID { get; set; }
        public string ROLENAME { get; set; }
        public Nullable<int> PERMISSIONID { get; set; }

        public virtual PAGE_MASTER_Base PAGE_MASTER { get; set; }
    }
}
