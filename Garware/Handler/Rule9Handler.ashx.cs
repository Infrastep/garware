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
    /// Summary description for Rule9Handler
    /// </summary>
    public class Rule9Handler : IHttpHandler
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

                    RULE9_Base obj = new RULE9_Base();
                    obj.RULE9ID = Convert.ToInt32(postdata.RULE9ID.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.SECONDARY_EARN_DEDN_CODE = Convert.ToInt16(postdata.SECONDARY_EARN_DEDN_CODE.ToString());
                    obj.MAX_NO_OF_DAYS = Convert.ToInt16(postdata.MAX_NO_OF_DAYS.ToString());
                    obj.MIN_NO_OF_DAYS = Convert.ToInt16(postdata.MIN_NO_OF_DAYS.ToString());
                  
                    obj.EARN_PRCNT = Convert.ToDecimal(postdata.EARN_PRCNT.ToString());
                    obj.ADD_BY = "JBT";
                    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);


                    RULE9BC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(RULE9BC.getdata());
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