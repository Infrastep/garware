using BaseClass.VM.RankMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class RANK_CLASS_Base
    {
       public RANK_CLASS_Base()
        {
            this.EMPLOYEE_CLIENT = new HashSet<EMPLOYEE_CLIENT_Base>();
        }
    
        public int RCID { get; set; }
        public Nullable<int> RANKID { get; set; }
        public Nullable<int> CLASSID { get; set; }
        public string Class_Type { get; set; }

        public virtual CLASS_Base CLASS { get; set; }
        public virtual ICollection<EMPLOYEE_CLIENT_Base> EMPLOYEE_CLIENT { get; set; }
        public virtual RANK_MASTER_Base_RM RANK_MASTER { get; set; }

    }
}
