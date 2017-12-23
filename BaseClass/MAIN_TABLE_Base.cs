using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
    public class MAIN_TABLE_Base
    {
        public int MAINTABLEID { get; set; }
        public Nullable<short> EARN_DEDN_CODE { get; set; }
        public Nullable<short> EMPL_CLASS { get; set; }
        public Nullable<System.DateTime> RULE_WEF_DATE { get; set; }
        public Nullable<System.DateTime> RULE_TILL_DATE { get; set; }
        public Nullable<short> RULE_TYPE { get; set; }
        public string INPUT_TYPE { get; set; }
        public string TAXABLE_FLAG { get; set; }
        public string IT_FORECAST_INDIC { get; set; }
        public string ACNT_CODE { get; set; }
        public string ACTIVITY_CODE { get; set; }
        public string ACC_SUB_CODE { get; set; }
        public string OFF_ON_BRD_PRD_FLAG { get; set; }
        public string OFF_HRB_PRD_FLAG { get; set; }
        public string OFF_STF_PRD_FLAG { get; set; }
        public string OFF_LEAVE_EARND_FLAG { get; set; }
        public string OFF_MDCLI_PRD_FLAG { get; set; }
        public string OFF_MDCLF_PRD_FLAG { get; set; }
        public string CRW_STF_PRD_FLAG { get; set; }
        public string CRW_ON_BRD_PRD_FLAG { get; set; }
        public string CRW_RETN1_PRD_FLAG { get; set; }
        public string CRW_RETN2_PRD_FLAG { get; set; }
        public string CRW_LEAVE_EARND_FLAG { get; set; }
        public string CRW_HOSPTLSD_IND_FLAG { get; set; }
        public string CRW_HOSPTLSD_ABROAD_FLAG { get; set; }
        public string CRW_MDCLI_PRD_FLAG { get; set; }
        public string CRW_UNFIT_PRD_FLAG { get; set; }
        public string CRW_ADV_FLAG { get; set; }
        public string CRW_MDCLF_PRD_FLAG { get; set; }
        public string CRW_CONTNS_SERVICE_FLAG { get; set; }
        public string RATE_TYPE { get; set; }
        public Nullable<short> SECONDARY_EARN_DEDN_CODE { get; set; }
        public string BIFURCATE { get; set; }
        public string ADD_BY { get; set; }
        public Nullable<System.DateTime> ADD_TIME { get; set; }
        public string EDIT_BY { get; set; }
        public Nullable<System.DateTime> EDIT_TIME { get; set; }
        public string ACNT_CODE_CO_DR { get; set; }
        public string ACTIVITY_CODE_CO_DR { get; set; }
        public string ACNT_CODE_CO_CR { get; set; }
        public string ACTIVITY_CODE_CO_CR { get; set; }
        public string ACNT_CODE_BB { get; set; }
        public string ACTIVITY_CODE_BB { get; set; }
        public string ACNT_CODE_BB_CO_DR { get; set; }
        public string ACTIVITY_CODE_BB_CO_DR { get; set; }
        public string ACNT_CODE_BB_CO_CR { get; set; }
        public string ACTIVITY_CODE_BB_CO_CR { get; set; }
        public int REC_ID_NO { get; set; }
    }
}
