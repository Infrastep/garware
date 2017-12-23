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
    /// Summary description for CertificateMasterHandler
    /// </summary>
    public class CertificateMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertCM")
            {
                CERTIFICATE_MASTER_Base obj = new CERTIFICATE_MASTER_Base();
                obj.CERTID = Convert.ToInt32(postdata.id.ToString());


                if (postdata.path.ToString() != string.Empty) { obj.PATH = Convert.ToString(postdata.path.ToString()); }

                obj.CERT_DESC = Convert.ToString(postdata.description.ToString());


                obj.EMP_ID = Convert.ToInt32(postdata.eid.ToString());
                obj.CTID = Convert.ToInt32(postdata.ctid.ToString());
                obj.VALIDITY = Convert.ToDateTime(postdata.validity.ToString(format.FullDateTimePattern));
                obj.LAST_MODIFY = DateTime.Now;
                CERTIFICATE_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetCM")
            {
                CERTIFICATE_MASTER_Base eb = new CERTIFICATE_MASTER_Base();
                eb.EMP_ID = Convert.ToInt32(postdata.id.ToString());
                var lst = CERTIFICATE_MASTERBC.getdatabyEmpId(eb);
                jstring = JsonConvert.SerializeObject(lst);
            }

            if (data == "GetCMById")
            {
                
                int CERTID = Convert.ToInt32(postdata.id.ToString());
                var lst = CERTIFICATE_MASTERBC.getdata(CERTID);
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetCMData")
            {

                
                var lst = CERTIFICATE_MASTERBC.getdata();
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