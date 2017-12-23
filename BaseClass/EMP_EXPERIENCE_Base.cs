using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class EMP_EXPERIENCE_Base
    {
        public int EEID { get; set; }
        public int EMP_id { get; set; }
        public string Company_Served { get; set; }
        public string Ship_name { get; set; }
        public Nullable<int> Ship_Type { get; set; }
        public string DWT { get; set; }
        public string Engine { get; set; }
        public string BHP { get; set; }
        public string Rank { get; set; }
        public Nullable<System.DateTime> Service_From { get; set; }
        public Nullable<System.DateTime> Service_To { get; set; }
        public Nullable<short> Months { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<bool> DIRECT { get; set; }
        public string Area_Sp_Job { get; set; }
        public string Area_Operation { get; set; }

        public virtual SHIP_TYPE_MASTER_Base SHIP_TYPE_MASTER { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
    }
}
