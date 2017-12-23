using BaseClass;
using BaseClass.VM.ActualSavings;
using BuisnessController;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for ActualSavingsHandler
    /// </summary>
    public class ActualSavingsHandler : IHttpHandler
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

                    ACTUAL_SAVINGS_Base_ACS obj = new ACTUAL_SAVINGS_Base_ACS();
                    obj.ACTUAL_SAVINGS_ID = Convert.ToInt32(postdata.ACTUAL_SAVINGS_ID.ToString());
                    obj.EMP_CODE = Convert.ToInt32(postdata.EMP_CODE.ToString());
                    obj.AMOUNT = Convert.ToDecimal(postdata.AMOUNT.ToString());
                    obj.FINANCIAL_YEAR = Convert.ToString(postdata.FINANCIAL_YEAR.ToString());
                    obj.CERTIFICATE_NO = Convert.ToString(postdata.CERTIFICATE_NO.ToString());
                    obj.TYPE = Convert.ToInt32(postdata.TYPE.ToString());
                    obj.NO_MONTHS = Convert.ToInt32(postdata.NO_MONTHS.ToString());
                    obj.SAVINGS_DATE = Convert.ToDateTime(postdata.SAVINGS_DATE.ToString());
                    obj.AUTH_TIME = DateTime.Now;
                    obj.AUTH_COMPUTER = "COM";
                    obj.AUTH_BY = "JBT";
                    obj.AUTH_DATE = DateTime.Now;
                    obj.AGREEMENT_CODE = Convert.ToInt32(postdata.AGREEMENT_CODE.ToString());
                    ACTUAL_SAVINGSBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(ACTUAL_SAVINGSBC.getdata());
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