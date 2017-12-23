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
    /// Summary description for KinDetailsHandler
    /// </summary>
    public class KinDetailsHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertKDM")
            {
                KIN_DETAILS_Base obj = new KIN_DETAILS_Base();



                obj.KINID = Convert.ToInt32(postdata.id.ToString());

                obj.EMPID = Convert.ToInt32(postdata.eid.ToString());
                obj.NAME = postdata.name.ToString();
                obj.ADDRESS1 = postdata.address1.ToString();
                obj.ADDRESS2 = postdata.address2.ToString();
                obj.CITY = postdata.city.ToString();
                obj.STATE = postdata.state.ToString();
                obj.COUNTRYID = Convert.ToInt32(postdata.country.ToString());
                obj.RELATIONSHIPID = Convert.ToInt32(postdata.relation.ToString());
                obj.EMAIL = postdata.email.ToString();
                obj.PHONE = postdata.phone.ToString();
                obj.PIN = postdata.pin.ToString();
                obj.GENDER = postdata.gender.ToString();
                obj.DOB = Convert.ToDateTime(postdata.dob.ToString());


                dynamic jso = KinDetailsBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject(jso);
            }

            if (data == "GetKDM")
            {
                KIN_DETAILS_Base eb = new KIN_DETAILS_Base();
                eb.EMPID = Convert.ToInt32(postdata.id.ToString());
                var lst = KinDetailsBC.getdatabyEmpId(eb);
                jstring = JsonConvert.SerializeObject(lst);
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