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
    /// Summary description for DGCertifiedHandler
    /// </summary>
    public class DutytypeMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertDT")
            {
                //DG_CERTIFIED_DOCTORS_Base obj = new DG_CERTIFIED_DOCTORS_Base();


                //obj.DGCDID = Convert.ToInt32(postdata.id.ToString());
                //obj.DOCTOR_NAME = Convert.ToString(postdata.name.ToString());
                //obj.CLINIC = Convert.ToString(postdata.clinic.ToString());
                //obj.ADDRESS1 = Convert.ToString(postdata.addr1.ToString());

                //obj.ADDRESS2 = Convert.ToString(postdata.addr2.ToString());
                //obj.CITY = Convert.ToString(postdata.city.ToString());
                //obj.STATE = Convert.ToString(postdata.state.ToString());
                //obj.PIN = postdata.pin.ToString();
              
                //obj.COUNTRYID = Convert.ToInt32(postdata.country.ToString());
                //obj.STATUS = Convert.ToBoolean(postdata.status.ToString());

                //DG_CERTIFIED_DOCTORSBC.insertupdateData(obj);

                //jstring = JsonConvert.SerializeObject("Success");
            }
            if (data == "Getdata")
            {
                jstring = JsonConvert.SerializeObject(DUTY_TYPE_MASTERBC.getdata());
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