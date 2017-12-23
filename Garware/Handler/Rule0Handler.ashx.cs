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
    /// Summary description for Rule0Handler
    /// </summary>
    public class Rule0Handler : IHttpHandler
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

                    RULE0_Base obj = new RULE0_Base();
                    obj.RULE0ID = Convert.ToInt32(postdata.RULE0ID.ToString());
                    obj.EARN_DEDN_CODE = Convert.ToInt16(postdata.EARN_DEDN_CODE.ToString());
                    obj.EMPL_CLASS = Convert.ToInt16(postdata.EMPL_CLASS.ToString());
                    obj.RULE_WEF_DATE = Convert.ToDateTime(postdata.RULE_WEF_DATE.ToString());
                    obj.RANK_CODE = Convert.ToString(postdata.RANK_CODE.ToString());
                    obj.SHIP_CODE = Convert.ToString(postdata.SHIP_CODE.ToString());
                     //obj.RANK_CODE = "042";
                     //obj.SHIP_CODE = "99";
                    obj.FROM_MONTH = Convert.ToInt16(postdata.FROM_MONTH.ToString());
                    obj.TO_MONTH = Convert.ToInt16(postdata.TO_MONTH.ToString());
                    obj.EARN_DEDN_RATE = Convert.ToDecimal(postdata.EARN_DEDN_RATE.ToString());
                    obj.ADD_BY = "JBT";
                    obj.ADD_TIME = Convert.ToDateTime(DateTime.Now);
                    
                    obj.EDIT_BY = "JBT";
                    obj.EDIT_TIME = Convert.ToDateTime(DateTime.Now);
                    
                    RULE0BC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(RULE0BC.getdata());
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