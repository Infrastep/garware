using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClass;
using DataAccess.EF;
using AutoMapper;
namespace DataAccess.Infrastructure
{
    public class MAIN_TABLEDL : COreEI
    {
        public List<MAIN_TABLE_Base> getdata()
        {

            List<MAIN_TABLE> dr = db1.MAIN_TABLE.ToList();
            List<MAIN_TABLE_Base> drb = generate_Base(dr);
            return drb;

        }

        public MAIN_TABLE_Base getdata(int id)
        {

            MAIN_TABLE dr = db1.MAIN_TABLE.Where(q => q.MAINTABLEID == id).Single();
            MAIN_TABLE_Base STM = generate_Base(dr);
            return STM;


        }

        public MAIN_TABLE_Base insertdata(MAIN_TABLE_Base dr)
        {
            int id = dr.MAINTABLEID;
            if (id != 0)
            {
                MAIN_TABLE result = db1.MAIN_TABLE.Where(q => q.MAINTABLEID == id).Single();
                if (result != null)
                {
                    result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                    result.EMPL_CLASS = dr.EMPL_CLASS;
                    result.CRW_ON_BRD_PRD_FLAG = dr.CRW_ON_BRD_PRD_FLAG;
                    result.CRW_MDCLI_PRD_FLAG = dr.CRW_MDCLI_PRD_FLAG;
                    result.CRW_LEAVE_EARND_FLAG = dr.CRW_LEAVE_EARND_FLAG;

                    result.CRW_HOSPTLSD_IND_FLAG = dr.CRW_HOSPTLSD_IND_FLAG;
                    result.CRW_HOSPTLSD_ABROAD_FLAG = dr.CRW_HOSPTLSD_ABROAD_FLAG;
                    result.CRW_CONTNS_SERVICE_FLAG = dr.CRW_CONTNS_SERVICE_FLAG;
                    result.CRW_ADV_FLAG = dr.CRW_ADV_FLAG;
                    result.CRW_RETN1_PRD_FLAG = dr.CRW_RETN1_PRD_FLAG;

                    result.CRW_RETN2_PRD_FLAG = dr.CRW_RETN2_PRD_FLAG;
                    result.CRW_STF_PRD_FLAG = dr.CRW_STF_PRD_FLAG;
                    result.CRW_UNFIT_PRD_FLAG = dr.CRW_UNFIT_PRD_FLAG;
                    result.EDIT_BY = dr.EDIT_BY;
                    result.EDIT_TIME = dr.EDIT_TIME;

                    result.INPUT_TYPE = dr.INPUT_TYPE;
                    result.IT_FORECAST_INDIC = dr.IT_FORECAST_INDIC;
                    result.OFF_HRB_PRD_FLAG = dr.OFF_HRB_PRD_FLAG;
                    result.OFF_LEAVE_EARND_FLAG = dr.OFF_LEAVE_EARND_FLAG;
                    result.OFF_MDCLF_PRD_FLAG = dr.OFF_MDCLF_PRD_FLAG;
                    result.OFF_MDCLI_PRD_FLAG = dr.OFF_MDCLI_PRD_FLAG;
                    result.OFF_ON_BRD_PRD_FLAG = dr.OFF_ON_BRD_PRD_FLAG;
                    result.OFF_STF_PRD_FLAG = dr.OFF_STF_PRD_FLAG;
                    result.RATE_TYPE = dr.RATE_TYPE;
                    result.REC_ID_NO = dr.REC_ID_NO;
                    result.RULE_TILL_DATE = dr.RULE_TILL_DATE;

                    result.RULE_TYPE = dr.RULE_TYPE;
                    result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                    result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                    result.TAXABLE_FLAG = dr.TAXABLE_FLAG;
                    result.BIFURCATE = dr.BIFURCATE;

                    result.ADD_TIME = dr.ADD_TIME;
                    result.ADD_BY = dr.ADD_BY;
                    result.ACTIVITY_CODE_CO_DR = dr.ACTIVITY_CODE_CO_DR;
                    result.ACC_SUB_CODE = dr.ACC_SUB_CODE;
                    result.ACNT_CODE = dr.ACNT_CODE;

                    result.ACNT_CODE_BB = dr.ACNT_CODE_BB;
                    result.ACNT_CODE_BB_CO_CR = dr.ACNT_CODE_BB_CO_CR;
                    result.ACNT_CODE_BB_CO_DR = dr.ACNT_CODE_BB_CO_DR;
                    result.ACNT_CODE_CO_CR = dr.ACNT_CODE_CO_CR;
                    result.ACNT_CODE_CO_DR = dr.ACNT_CODE_CO_DR;

                    result.ACTIVITY_CODE = dr.ACTIVITY_CODE;
                    result.ACTIVITY_CODE_BB = dr.ACTIVITY_CODE_BB;
                    
                    CommitChanges();
                }
                return generate_Base(result);
            }
            else
            {
                MAIN_TABLE result = new MAIN_TABLE();

                result.EARN_DEDN_CODE = dr.EARN_DEDN_CODE;
                result.EMPL_CLASS = dr.EMPL_CLASS;
                result.CRW_ON_BRD_PRD_FLAG = dr.CRW_ON_BRD_PRD_FLAG;
                result.CRW_MDCLI_PRD_FLAG = dr.CRW_MDCLI_PRD_FLAG;
                result.CRW_LEAVE_EARND_FLAG = dr.CRW_LEAVE_EARND_FLAG;

                result.CRW_HOSPTLSD_IND_FLAG = dr.CRW_HOSPTLSD_IND_FLAG;
                result.CRW_HOSPTLSD_ABROAD_FLAG = dr.CRW_HOSPTLSD_ABROAD_FLAG;
                result.CRW_CONTNS_SERVICE_FLAG = dr.CRW_CONTNS_SERVICE_FLAG;
                result.CRW_ADV_FLAG = dr.CRW_ADV_FLAG;
                result.CRW_RETN1_PRD_FLAG = dr.CRW_RETN1_PRD_FLAG;

                result.CRW_RETN2_PRD_FLAG = dr.CRW_RETN2_PRD_FLAG;
                result.CRW_STF_PRD_FLAG = dr.CRW_STF_PRD_FLAG;
                result.CRW_UNFIT_PRD_FLAG = dr.CRW_UNFIT_PRD_FLAG;
                result.EDIT_BY = dr.EDIT_BY;
                result.EDIT_TIME = dr.EDIT_TIME;

                result.INPUT_TYPE = dr.INPUT_TYPE;
                result.IT_FORECAST_INDIC = dr.IT_FORECAST_INDIC;
                result.OFF_HRB_PRD_FLAG = dr.OFF_HRB_PRD_FLAG;
                result.OFF_LEAVE_EARND_FLAG = dr.OFF_LEAVE_EARND_FLAG;
                result.OFF_MDCLF_PRD_FLAG = dr.OFF_MDCLF_PRD_FLAG;

                result.OFF_ON_BRD_PRD_FLAG = dr.OFF_ON_BRD_PRD_FLAG;
                result.OFF_STF_PRD_FLAG = dr.OFF_STF_PRD_FLAG;
                result.RATE_TYPE = dr.RATE_TYPE;
                result.REC_ID_NO = dr.REC_ID_NO;
                result.RULE_TILL_DATE = dr.RULE_TILL_DATE;

                result.RULE_TYPE = dr.RULE_TYPE;
                result.RULE_WEF_DATE = dr.RULE_WEF_DATE;
                result.SECONDARY_EARN_DEDN_CODE = dr.SECONDARY_EARN_DEDN_CODE;
                result.TAXABLE_FLAG = dr.TAXABLE_FLAG;
                result.BIFURCATE = dr.BIFURCATE;

                result.ADD_TIME = dr.ADD_TIME;
                result.ADD_BY = dr.ADD_BY;
                result.ACTIVITY_CODE_CO_DR = dr.ACTIVITY_CODE_CO_DR;
                result.ACC_SUB_CODE = dr.ACC_SUB_CODE;
                result.ACNT_CODE = dr.ACNT_CODE;

                result.ACNT_CODE_BB = dr.ACNT_CODE_BB;
                result.ACNT_CODE_BB_CO_CR = dr.ACNT_CODE_BB_CO_CR;
                result.ACNT_CODE_BB_CO_DR = dr.ACNT_CODE_BB_CO_DR;
                result.ACNT_CODE_CO_CR = dr.ACNT_CODE_CO_CR;
                result.ACNT_CODE_CO_DR = dr.ACNT_CODE_CO_DR;

                result.ACTIVITY_CODE = dr.ACTIVITY_CODE;
                result.ACTIVITY_CODE_BB = dr.ACTIVITY_CODE_BB;

                db1.MAIN_TABLE.Add(result);
                CommitChanges();
                return generate_Base(result);
            }
        }

        public static MAIN_TABLE_Base generate_Base(MAIN_TABLE dr)
        {

            MAIN_TABLE_Base drb = Mapper.DynamicMap<MAIN_TABLE, MAIN_TABLE_Base>(dr);

            return drb;
        }

        public static List<MAIN_TABLE_Base> generate_Base(ICollection<MAIN_TABLE> i)
        {
            List<MAIN_TABLE_Base> drbl = Mapper.DynamicMap<ICollection<MAIN_TABLE>, List<MAIN_TABLE_Base>>(i);

            return drbl;
        }

    }
}

