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
    /// Summary description for WithheldRefundHandler
    /// </summary>
    public class WithheldRefundHandler : IHttpHandler
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

                    WITHHELD_REFUND_Base obj = new WITHHELD_REFUND_Base();
                    obj.ID = Convert.ToInt32(postdata.ID.ToString());
                    obj.EMP_CODE = Convert.ToInt32(postdata.EMP_CODE.ToString());
                    obj.AMOUNT = Convert.ToString(postdata.AMOUNT.ToString());
                    obj.FINANCIAL_YEAR = Convert.ToString(postdata.FINANCIAL_YEAR.ToString());
                    obj.REMARKS = Convert.ToString(postdata.REMARKS.ToString());
                    obj.REF_PREFIX = "R";
                    obj.REF_NO = Convert.ToInt32(postdata.REF_NO.ToString());
                    obj.REF_DATE = Convert.ToDateTime(postdata.REF_DATE.ToString());
                    WITHHELD_REFUNDBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(WITHHELD_REFUNDBC.getdata());
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