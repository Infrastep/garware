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
    /// Summary description for Rule7Handler
    /// </summary>
    public class Rule7Handler : IHttpHandler
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

                    RULE7_Base obj = new RULE7_Base();
                    obj.RULE7ID = Convert.ToInt32(postdata.RULE7ID.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.MIN_NO_OF_YRS = Convert.ToInt16(postdata.MIN_NO_OF_YRS.ToString());
                    obj.EARN_DEDN_RATE = Convert.ToDecimal(postdata.EARN_DEDN_RATE.ToString());
                    obj.MAX_NO_OF_YRS = Convert.ToInt16(postdata.MAX_NO_OF_YRS.ToString());
                    
                    obj.ADD_BY = "JBT";
                    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);


                    RULE7BC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(RULE7BC.getdata());
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