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
    /// Summary description for PageMasterHandler
    /// </summary>
    public class PageMasterHandler : IHttpHandler
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
                //case "InsertUpdate":

                //    PAGE_MASTER_Base obj = new PAGE_MASTER_Base();
                //    obj.PAGE_MASTERID = Convert.ToInt32(postdata.PAGE_MASTERID.ToString());
                //    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                //    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                //    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                //    obj.AMOUNT_DPM_MPY_FLAG = Convert.ToString(postdata.AMOUNT_DPM_MPY_FLAG.ToString());
                //    obj.EARN_DEDN_RATE = Convert.ToDecimal(postdata.EARN_DEDN_RATE.ToString());
                //    obj.ADD_BY = "JBT";
                //    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                //    obj.EDIT_BY = "JBT";
                //    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);
                //    obj.xx = 120;
                //    PAGE_MASTERBC.insertupdateData(obj);

                //    jstring = JsonConvert.SerializeObject("Success");
                //    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(PAGE_MASTERBC.getdata());
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