using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
namespace Frontend.Handler
{
    /// <summary>
    /// Summary description for CertificateTypeMasterHandler
    /// </summary>
    public class CertificateTypeMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertCTM")
            {
                CERTIFICATE_TYPE_MASTER_Base obj = new CERTIFICATE_TYPE_MASTER_Base();
                obj.CTID = Convert.ToInt32(postdata.id.ToString());



                obj.CT_DESC = Convert.ToString(postdata.description.ToString());



                CERTIFICATE_TYPE_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetCTM")
            {

                var lst = CERTIFICATE_TYPE_MASTERBC.getdata();
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