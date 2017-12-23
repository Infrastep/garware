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
    /// Summary description for ClientMasterHandler
    /// </summary>
    public class ClientMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();

            if (data == "InsertCLM")
            {
                CLIENT_MASTER_Base obj = new CLIENT_MASTER_Base();

                obj.CLIENTID = Convert.ToInt32(postdata.id.ToString());
                obj.CLIENT_NAME = postdata.clientname.ToString();
                //obj.DATABASE_NAME = postdata.dbname.ToString();
                //obj.DATABASE_HOST = postdata.dbhost.ToString();
                //obj.DATABASE_UID = postdata.dbuid.ToString();
                //obj.DATABASE_PASS = postdata.dbpsw.ToString();
                if (postdata.address != null)
                { obj.ADDRESS = postdata.address.ToString(); }
                else
                {
                    obj.ADDRESS = "";
                }

                obj.PIN = postdata.pin.ToString();
                obj.CITY = postdata.city.ToString();

                obj.STATE = postdata.state.ToString();
                obj.PHONE = postdata.phone.ToString();
                obj.FAX_NO = postdata.fax.ToString();

                obj.EMAIL = postdata.email.ToString();
                obj.SERVICE_TAX_NO = postdata.tax.ToString();
                obj.CIN_NO = postdata.CIN_NO.ToString();
                obj.PAN = postdata.PAN.ToString();
                obj.TAN = postdata.TAN.ToString();
                obj.COUNTRY_ID = Convert.ToInt32(postdata.COUNTRY_ID.ToString());
                obj.WEBSITE = postdata.WEBSITE.ToString();
                obj.PICTURE = postdata.path.ToString();
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
                obj.CLIENT_LOGO = "";
                obj.DESCRIPTION = "";
                CLIENT_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }



            if (data == "GetCLM")
            {

                List<CLIENT_MASTER_Base> lst = new List<CLIENT_MASTER_Base>();

                lst = CLIENT_MASTERBC.getdata().ToList();

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