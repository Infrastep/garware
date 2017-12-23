using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class COMMENT_Base
    {
        public int COMMENTID { get; set; }
        public string COMMENT1 { get; set; }
        public Nullable<int> RECEIVERUSERID { get; set; }
        public Nullable<int> SENDERUSERID { get; set; }
        public Nullable<int> EMPID { get; set; }
        public Nullable<System.DateTime> COMMENTDATE { get; set; }
        public Nullable<bool> PRIVATE { get; set; }
        public Nullable<bool> PUBLIC { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED1 { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED2 { get; set; }

    }
}
