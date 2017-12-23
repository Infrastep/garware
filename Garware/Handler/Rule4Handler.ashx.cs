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
    /// Summary description for Rule4Handler
    /// </summary>
    public class Rule4Handler : IHttpHandler
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

                    RULE4_Base obj = new RULE4_Base();
                    obj.RULE4ID = Convert.ToInt32(postdata.RULE4ID.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.SECONDARY_EARN_DEDN_CODE = Convert.ToInt16(postdata.SECONDARY_EARN_DEDN_CODE.ToString());
                    obj.EARN_DEDN_RATE = Convert.ToDecimal(postdata.EARN_DEDN_RATE.ToString());
                    obj.FIXED_PRCNT_OTRATE_FLAG = Convert.ToString(postdata.FIXED_PRCNT_OTRATE_FLAG.ToString());
                    obj.MIN_SECONDARY_EARN_AMT = Convert.ToDecimal(postdata.MIN_SECONDARY_EARN_AMT.ToString());
                    obj.MAX_SECONDARY_EARN_AMT = Convert.ToDecimal(postdata.MAX_SECONDARY_EARN_AMT.ToString());
                    obj.ADD_BY = "JBT";
                    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);
                   
                    obj.XX = 120;
                    RULE4BC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(RULE4BC.getdata());
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