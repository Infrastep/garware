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
    /// Summary description for AddressMasterHandler
    /// </summary>
    public class AddressMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertAM")
            {
                ADDRESSEE_MASTER_Base obj = new ADDRESSEE_MASTER_Base();
                obj.ADDRESSID = Convert.ToInt32(postdata.id.ToString());
                obj.ADDR0 = Convert.ToString(postdata.addr0.ToString());
                obj.ADDR1 = Convert.ToString(postdata.addr1.ToString());
                obj.CITY = Convert.ToString(postdata.city.ToString());
                obj.COUNTRY = Convert.ToInt32(postdata.country.ToString());
                obj.ZIP = Convert.ToString(postdata.zip.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
                obj.COMPANYID = Convert.ToInt32(postdata.cid.ToString());
               
                ADDRESSEE_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetAM")
            {
                List<ADDRESSEE_MASTER_Base> lst = new List<ADDRESSEE_MASTER_Base>();
                lst = ADDRESSEE_MASTERBC.getdata();
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