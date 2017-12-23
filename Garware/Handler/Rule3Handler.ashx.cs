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
    /// Summary description for Rule3Handler
    /// </summary>
    public class Rule3Handler : IHttpHandler
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

                    RULE3_Base obj = new RULE3_Base();
                    obj.RULE3ID = Convert.ToInt32(postdata.RULE3ID.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.SECONDARY_EARN_DEDN_CODE = Convert.ToInt16(postdata.SECONDARY_EARN_DEDN_CODE.ToString());
                    obj.EARN_DEDN_RATE = Convert.ToDecimal(postdata.EARN_DEDN_RATE.ToString());
                    obj.FIXED_PRCNT_DPM_FLAG = Convert.ToString(postdata.FIXED_PRCNT_DPM_FLAG.ToString());
                    obj.ADD_BY = "JBT";
                    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);
                    obj.RANK_CODE = Convert.ToString(postdata.RANK_CODE.ToString());
                    obj.s = 120;
                    RULE3BC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(RULE3BC.getdata());
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