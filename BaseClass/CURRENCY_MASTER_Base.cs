using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class CURRENCY_MASTER_Base
    {
        public int Currency_id { get; set; }
        public string title { get; set; }
        public string code { get; set; }
        public string symbol_left { get; set; }
        public string symbol_right { get; set; }
        public string decimal_place { get; set; }
        public Nullable<decimal> value { get; set; }
        public Nullable<bool> status { get; set; }
    }
}
