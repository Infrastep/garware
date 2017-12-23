using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class AGREEMENT_DETAILS_Base
    {
       public AGREEMENT_DETAILS_Base()
        {
            this.ACTUAL_SAVINGS = new HashSet<ACTUAL_SAVINGS_Base>();
            this.WITHHELD_TRANSFER = new HashSet<WITHHELD_TRANSFER_Base>();
        }
    
        public int AGREEMENT_DETAILS_ID { get; set; }
        public string AGREEMENT_CODE { get; set; }
        public int VCODE { get; set; }
        public string VNAME { get; set; }
        public int EMP_CODE { get; set; }
        public string EMP_NAME { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string RANK_CODE { get; set; }
        public string RANK_DESC { get; set; }
        public Nullable<decimal> BASIC { get; set; }
        public Nullable<decimal> bonus { get; set; }
        public Nullable<decimal> GROSS { get; set; }
        public string AGENT_NAME { get; set; }
        public string SIGNING_AUTH_NAME { get; set; }
        public string SIGN_DESG { get; set; }
        public string LIMITATION { get; set; }
        public string END_CODE { get; set; }
        public string PF_RATE { get; set; }
        public string ALLOTMENT_AMOUNT { get; set; }
        public Nullable<System.DateTime> ref_date { get; set; }
        public string ref_no { get; set; }
        public Nullable<System.DateTime> appl_date { get; set; }
        public Nullable<decimal> basic_insa { get; set; }
        public Nullable<byte> months { get; set; }
        public string MUI_NMB { get; set; }
        public string GRAT_RATE { get; set; }
        public string MED_CERT_ISS_AUTH { get; set; }
        public string MED_CERT_APPR_NO { get; set; }
        public string MED_CERT_ISS_DATE { get; set; }
        public string MED_CERT_EXP_DATE { get; set; }
        public string PLACE_AGREEMENT { get; set; }
        public string COMPANY { get; set; }
        public Nullable<bool> TRAINEE_CREW { get; set; }
        public Nullable<bool> PF_APPLICABLE { get; set; }

        public virtual ICollection<ACTUAL_SAVINGS_Base> ACTUAL_SAVINGS { get; set; }
        public virtual EMP_FIXED_Base EMP_FIXED { get; set; }
        public virtual SHIP_MASTER_Base SHIP_MASTER { get; set; }
        public virtual ICollection<WITHHELD_TRANSFER_Base> WITHHELD_TRANSFER { get; set; }
    }
}
