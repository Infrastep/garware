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
    /// Summary description for AgreementDetailsHandler
    /// </summary>
    public class AgreementDetailsHandler : IHttpHandler
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

                    //AGREEMENT_DETAILS_Base_AD obj = new AGREEMENT_DETAILS_Base_AD();
                    ////obj.AGREEMENT_DETAILS_ID = Convert.ToInt32(postdata.ID.ToString());
                    ////obj.EMP_CODE = Convert.ToInt32(postdata.EMP_CODE.ToString());
                    ////obj.YR = Convert.ToString(postdata.YR.ToString());
                    ////obj.MON = Convert.ToString(postdata.MON.ToString());
                    ////obj.TRANS_AMT = Convert.ToDecimal(postdata.TRANS_AMT.ToString());
                    ////obj.AGREEMENT_CODE = Convert.ToInt32(postdata.AGREEMENT_CODE.ToString());

                    //AGREEMENT_DETAILSBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdataref":

                    jstring = JsonConvert.SerializeObject(AGREEMENT_DETAILSBC.getdata(postdata.refno.ToString()));
                    break;

                case "Getdataid":

                    jstring = JsonConvert.SerializeObject(AGREEMENT_DETAILSBC.getdata(Convert.ToInt32(postdata.id)));
                    break;


                case "Getdata":

                    jstring = JsonConvert.SerializeObject(AGREEMENT_DETAILSBC.getdata());
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