using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class AEDCODE_Base
    {
        public int Id { get; set; }
        public short CODE { get; set; }
        public string DESCR { get; set; }
        public string AED { get; set; }
        public string EARNING_TYPE { get; set; }
        public string EMP_BRK { get; set; }
        public string TAXABLE_YN { get; set; }
        public Nullable<short> PRIORITY { get; set; }
        public string ACCODE { get; set; }
        public string SUBCD { get; set; }
        public string ACDESC { get; set; }
        public string EDDESC { get; set; }
        public string DC { get; set; }
        public string INT_YN { get; set; }
        public Nullable<decimal> INT_RATE { get; set; }
        public string PTAX_YN { get; set; }
        public string ESI_YN { get; set; }
        public string DETAIL_YN { get; set; }
    }
}
