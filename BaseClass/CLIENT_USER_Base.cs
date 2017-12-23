using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class CLIENT_USER_Base
   {
       public int CLIENTUSERID { get; set; }
       public Nullable<int> CLIENTID { get; set; }
       public Nullable<int> USERID { get; set; }

       public virtual CLIENT_MASTER_Base CLIENT_MASTER { get; set; }
       public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
