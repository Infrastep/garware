using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for MainTableOfficerHandler
    /// </summary>
    public class MainTableOfficerHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            switch (data)
            {
                case "InsertUpdate":

                    MAIN_TABLE_Base obj = new MAIN_TABLE_Base();

                    obj.MAINTABLEID = Convert.ToInt32(postdata.id.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());

                    obj.CRW_ON_BRD_PRD_FLAG = DBNull.Value.ToString();
                    obj.CRW_MDCLI_PRD_FLAG = DBNull.Value.ToString();
                    obj.CRW_LEAVE_EARND_FLAG = DBNull.Value.ToString();
                    obj.CRW_HOSPTLSD_IND_FLAG = DBNull.Value.ToString();
                    obj.CRW_HOSPTLSD_ABROAD_FLAG = DBNull.Value.ToString();
                    obj.CRW_CONTNS_SERVICE_FLAG = DBNull.Value.ToString();
                    obj.CRW_ADV_FLAG = DBNull.Value.ToString();
                    obj.CRW_RETN1_PRD_FLAG = DBNull.Value.ToString();
                    obj.CRW_RETN2_PRD_FLAG = DBNull.Value.ToString();
                    obj.CRW_STF_PRD_FLAG = DBNull.Value.ToString();
                    obj.CRW_UNFIT_PRD_FLAG = DBNull.Value.ToString();

                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = DateTime.Now;

                    obj.INPUT_TYPE = Convert.ToString(postdata.INPUT_TYPE.ToString());
                    obj.IT_FORECAST_INDIC = Convert.ToString(postdata.IT_FORECAST_INDIC.ToString());

                    obj.OFF_HRB_PRD_FLAG = Convert.ToString(postdata.OFF_HRB_PRD_FLAG.ToString());
                    obj.OFF_LEAVE_EARND_FLAG = Convert.ToString(postdata.OFF_LEAVE_EARND_FLAG.ToString());
                    obj.OFF_MDCLF_PRD_FLAG = Convert.ToString(postdata.OFF_MDCLF_PRD_FLAG.ToString());
                    obj.OFF_MDCLI_PRD_FLAG = Convert.ToString(postdata.OFF_MDCLI_PRD_FLAG.ToString());
                    obj.OFF_ON_BRD_PRD_FLAG = Convert.ToString(postdata.OFF_ON_BRD_PRD_FLAG.ToString());
                    obj.OFF_STF_PRD_FLAG = Convert.ToString(postdata.OFF_STF_PRD_FLAG.ToString());
                    
                    obj.RATE_TYPE = Convert.ToString(postdata.RATE_TYPE.ToString());
                    obj.REC_ID_NO = 772;
                    obj.RULE_TILL_DATE = Convert.ToDateTime(postdata.RULE_TILL_DATE.ToString());
                    obj.RULE_TYPE = Convert.ToInt16(postdata.RULE_TYPE.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.SECONDARY_EARN_DEDN_CODE = 0;
                    obj.TAXABLE_FLAG = Convert.ToString(postdata.TAXABLE_FLAG.ToString());
                    obj.BIFURCATE = DBNull.Value.ToString();

                    obj.ADD_TIME = DateTime.Now;
                    obj.ADD_BY = "JBT";
                    obj.ACTIVITY_CODE = DBNull.Value.ToString();
                    obj.ACC_SUB_CODE = DBNull.Value.ToString();
                    obj.ACNT_CODE = DBNull.Value.ToString();
                    obj.ACNT_CODE_BB = DBNull.Value.ToString();
                    obj.ACNT_CODE_BB_CO_CR = DBNull.Value.ToString();
                    obj.ACNT_CODE_BB_CO_DR = DBNull.Value.ToString();
                    obj.ACNT_CODE_CO_CR = DBNull.Value.ToString();
                    obj.ACNT_CODE_CO_DR = DBNull.Value.ToString();
                    obj.ACTIVITY_CODE_BB = DBNull.Value.ToString();
                    MAIN_TABLEBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(MAIN_TABLEBC.getdata());
                    break;
            }

            context.Response.ContentType = "application / json";
            context.Response.Write(jstring);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}