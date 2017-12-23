using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
  public  class ADDRESSEE_MASTER_Base
    {
        public int ADDRESSID { get; set; }
        public string ADDR0 { get; set; }
        public string ADDR1 { get; set; }
        public string CITY { get; set; }
        public Nullable<int> COUNTRY { get; set; }
        public string ZIP { get; set; }
        public Nullable<int> COMPANYID { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual COMPANY_PARAMETER_Base COMPANY_PARAMETER { get; set; }
        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
    }
}
