using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class TAX_SLAB_Base
    {
        public int ID { get; set; }
        public string TYPE { get; set; }
        public string FINANCIAL_YEAR { get; set; }
        public Nullable<decimal> FROM_AMT { get; set; }
        public Nullable<decimal> TO_AMT { get; set; }
        public Nullable<decimal> TAX_PER { get; set; }
        public Nullable<decimal> TAX_AMT { get; set; }
        public Nullable<bool> STATUS { get; set; }
    }
}
