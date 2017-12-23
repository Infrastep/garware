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
    /// Summary description for SectionLimitHandler
    /// </summary>
    public class SectionLimitHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertSL")
            {
                SECTION_LIMIT_Base obj = new SECTION_LIMIT_Base();
                obj.ID = Convert.ToInt32(postdata.id.ToString());
                obj.SECTION = Convert.ToString(postdata.section.ToString());
                obj.MAX_LIMIT = Convert.ToDecimal(postdata.max.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());

                SectionLimitBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetSL")
            {
                List<SECTION_LIMIT_Base> lst = new List<SECTION_LIMIT_Base>();
                lst = SectionLimitBC.getdata();
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