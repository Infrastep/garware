using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class GRATUITY_REMIT_Base
    {
        public int GRATUITY_REMITID { get; set; }
        public string REF_NO { get; set; }
        public Nullable<System.DateTime> REF_DT { get; set; }
        public string ADDR0 { get; set; }
        public string ADDR1 { get; set; }
        public string ADDR2 { get; set; }
        public string ADDR3 { get; set; }
        public string ADDR4 { get; set; }
        public string REMIT_CHQ_NO { get; set; }
        public Nullable<System.DateTime> REMIT_CHQ_DT { get; set; }
        public string REMIT_BANK { get; set; }
        public Nullable<decimal> REMIT_AMT { get; set; }
        public string AUTH_SIGN { get; set; }
        public string AUTH_DESIG { get; set; }
    }
}
