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
    /// Summary description for Rule8Handler
    /// </summary>
    public class Rule8Handler : IHttpHandler
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

                    RULE8_Base obj = new RULE8_Base();
                    obj.RULE8ID = Convert.ToInt32(postdata.RULE8ID.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.SECONDARY_EARN_DEDN_CODE = Convert.ToInt16(postdata.SECONDARY_EARN_DEDN_CODE.ToString());
                    obj.PROLONG_FROM_MONTH = Convert.ToInt16(postdata.PROLONG_FROM_MONTH.ToString());
                    obj.PROLONG_TO_MONTH = Convert.ToInt16(postdata.PROLONG_TO_MONTH.ToString());
                    obj.SHIP_CODE = Convert.ToString(postdata.SHIP_CODE.ToString());
                    //obj.SHIP_CODE = "99";
                    obj.PRCNT_IN_FIRST_PERIOD = Convert.ToDecimal(postdata.PRCNT_IN_FIRST_PERIOD.ToString());
                    obj.PRCNT_IN_SECOND_PERIOD = Convert.ToDecimal(postdata.PRCNT_IN_SECOND_PERIOD.ToString());
                    obj.PRCNT_IN_THIRD_PERIOD = Convert.ToDecimal(postdata.PRCNT_IN_THIRD_PERIOD.ToString());

                    obj.ADD_BY = "JBT";
                    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);


                    RULE8BC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(RULE8BC.getdata());
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