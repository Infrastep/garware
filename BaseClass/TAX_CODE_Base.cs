using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class TAX_CODE_Base
    {
        public int ID { get; set; }
        public string DESCRIPTIONS { get; set; }
        public string SAVINGS_TYPE { get; set; }
        public Nullable<int> UNDER_SECTION { get; set; }
        public string INCOME_TYPE { get; set; }

        public virtual SECTION_LIMIT_Base SECTION_LIMIT { get; set; }
    }
}
