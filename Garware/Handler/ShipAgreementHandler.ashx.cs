using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass.VM.ShipAgreement;
using BuisnessController;
using Newtonsoft.Json;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for ShipAgreementMasterHandler
    /// </summary>
    public class ShipAgreementHandler : IHttpHandler
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

                    SHIP_AGREEMENT_Base_SA obj = new SHIP_AGREEMENT_Base_SA();
                    obj.Id = Convert.ToInt32(postdata.id.ToString());
                    obj.ClientId = Convert.ToInt32(postdata.ClientId.ToString());
                    obj.Startdate = Convert.ToDateTime(postdata.Startdate.ToString());
                    obj.Enddate = Convert.ToDateTime(postdata.Enddate.ToString());
                    obj.AgreementType = Convert.ToInt16(postdata.AgreementType.ToString());
                    obj.ShipId = Convert.ToInt16(postdata.ShipId.ToString());



                    jstring = JsonConvert.SerializeObject(SHIP_AGREEMENTBC.insertupdateData(obj));
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(SHIP_AGREEMENTBC.getdata());
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