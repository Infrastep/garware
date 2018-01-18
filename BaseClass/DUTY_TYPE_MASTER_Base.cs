using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class DUTY_TYPE_MASTER_Base
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> CATEGORY { get; set; }
        public string ACTIVE { get; set; }
        public string EMP_TYPE { get; set; }

        //public virtual CATEGORY_Base CATEGORY1 { get; set; }
    }
}
