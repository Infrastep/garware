using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class DG_CERTIFIED_DOCTORS_Base
    {
        public int DGCDID { get; set; }
        public string DOCTOR_NAME { get; set; }
        public string CLINIC { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string PIN { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }

    }
}
