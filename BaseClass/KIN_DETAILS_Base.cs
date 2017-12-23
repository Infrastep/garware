using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class KIN_DETAILS_Base
    {
        public int KINID { get; set; }
        public string NAME { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public Nullable<int> COUNTRYID { get; set; }
        public string PIN { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> EMPID { get; set; }
        public string GENDER { get; set; }
        public Nullable<int> RELATIONSHIPID { get; set; }

        public virtual COUNTRY_MASTER_Base COUNTRY_MASTER { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual RELATIONSHIP_MASTER_Base RELATIONSHIP_MASTER { get; set; }

    }
}
