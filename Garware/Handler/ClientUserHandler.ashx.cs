using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System.Web.Security;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for ClientUserHandler
    /// </summary>
    public class ClientUserHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertCU")
            {
                dynamic jso = null;
                CLIENT_USER_Base obj = new CLIENT_USER_Base();
                try
                {
                    obj.CLIENTUSERID = Convert.ToInt32(postdata.id.ToString());
                    obj.USERID = Convert.ToInt32(postdata.uid.ToString());
                    obj.CLIENTID =Convert.ToInt32( postdata.clientid.ToString());
                    jso = CLIENT_USERBC.insertupdateData(obj);
                    jstring = JsonConvert.SerializeObject(jso);
                }
                catch (Exception rr)
                { }
            }

            if (data == "GetCL")
            {

                CLIENT_USER_Base lst = new CLIENT_USER_Base();
                int Uid = Convert.ToInt32(postdata.uid.ToString());

                lst = CLIENT_USERBC.getdata(Uid);


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