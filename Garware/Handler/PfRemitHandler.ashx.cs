using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for PfRemitHandler
    /// </summary>
    public class PfRemitHandler : IHttpHandler
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

                    PF_REMIT_Base obj = new PF_REMIT_Base();
                    obj.PF_REMIT_ID = Convert.ToInt32(postdata.PF_REMIT_ID.ToString());
                    obj.REF_NO = Convert.ToString(postdata.REF_NO.ToString());
                    obj.REF_DT = Convert.ToDateTime(postdata.REF_DT.ToString());
                    obj.ADDR0 = Convert.ToString(postdata.ADDR0.ToString());
                    obj.ADDR1 = Convert.ToString(postdata.ADDR1.ToString());
                    obj.ADDR2 = Convert.ToString(postdata.ADDR2.ToString());
                    obj.ADDR3 = Convert.ToString(postdata.ADDR3.ToString());
                    obj.ADDR4 = Convert.ToString(postdata.ADDR4.ToString());
                    obj.REMIT_CHQ_NO = Convert.ToString(postdata.REMIT_CHQ_NO.ToString());
                    obj.REMIT_CHQ_DT = Convert.ToDateTime(postdata.REMIT_CHQ_DT.ToString());
                    obj.REMIT_BANK = Convert.ToString(postdata.REMIT_BANK.ToString());
                    obj.REMIT_AMT = Convert.ToDecimal(postdata.REMIT_AMT.ToString());
                    obj.ADMN_CHQ_NO = Convert.ToString(postdata.ADMN_CHQ_NO.ToString());
                    obj.ADMN_CHQ_DT = Convert.ToDateTime(postdata.ADMN_CHQ_DT.ToString());
                    obj.ADMN_BANK = Convert.ToString(postdata.ADMN_BANK.ToString());
                    obj.ADMN_AMT = Convert.ToDecimal(postdata.ADMN_AMT.ToString());
                    obj.AUTH_SIGN = Convert.ToString(postdata.AUTH_SIGN.ToString());
                    obj.AUTH_DESIG = Convert.ToString(postdata.AUTH_DESIG.ToString());
                    PF_REMITBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(PF_REMITBC.getdata());
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