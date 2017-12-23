using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class PF_REMIT_Base
  {
      public int PF_REMIT_ID { get; set; }
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
      public string ADMN_CHQ_NO { get; set; }
      public Nullable<System.DateTime> ADMN_CHQ_DT { get; set; }
      public string ADMN_BANK { get; set; }
      public Nullable<decimal> ADMN_AMT { get; set; }
      public string AUTH_SIGN { get; set; }
      public string AUTH_DESIG { get; set; }
    }
}
