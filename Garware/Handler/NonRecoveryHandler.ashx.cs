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
    /// Summary description for NonRecoveryHandler
    /// </summary>
    public class NonRecoveryHandler : IHttpHandler
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

                    NON_RECOVERY_Base obj = new NON_RECOVERY_Base();
                    obj.ID = Convert.ToInt32(postdata.ID.ToString());
                    obj.EMP_CODE = Convert.ToInt32(postdata.EMP_CODE.ToString());
                    obj.AMOUNT = Convert.ToString(postdata.AMOUNT.ToString());
                   
                    obj.REMARKS = Convert.ToString(postdata.REMARKS.ToString());
                    obj.INACTIVE_BY = "JBT";
                    obj.INACTIVE_TIME = DateTime.Now;
                    obj.INACTIVE_COMPUTER = "COM";
                    NON_RECOVERYBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(NON_RECOVERYBC.getdata());
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