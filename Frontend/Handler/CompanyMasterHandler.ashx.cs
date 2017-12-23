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
    /// Summary description for CompanyMasterHandler
    /// </summary>
    public class CompanyMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();


            if (data == "GetCompany")
            {
                List<COMPANY_PARAMETER_Base> lst = new List<COMPANY_PARAMETER_Base>();
                lst = COMPANY_PARAMETERBC.getdata();
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