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
    /// Summary description for CountryMasterHandler
    /// </summary>
    public class CountryMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertCOUNTRY")
            {
                COUNTRY_MASTER_Base obj = new COUNTRY_MASTER_Base();
                obj.CID = Convert.ToInt32(postdata.id.ToString());
                obj.CCODE = Convert.ToString(postdata.code.ToString());
                obj.C_Name = Convert.ToString(postdata.name.ToString());
                obj.add_by = "";
                obj.Edit_by = "";
                obj.add_time = DateTime.Now;
                obj.Edit_time = DateTime.Now;
                COUNTRY_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }
            if (data == "GetCountry")
            {
                List<COUNTRY_MASTER_Base> lst = new List<COUNTRY_MASTER_Base>();
                lst = COUNTRY_MASTERBC.getdata();
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