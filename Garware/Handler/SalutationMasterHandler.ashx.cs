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
    /// Summary description for SalutationMasterHandler
    /// </summary>
    public class SalutationMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertSM")
            {
                SALUTATION_Base obj = new SALUTATION_Base();
                obj.SalutationID = Convert.ToInt32(postdata.id.ToString());
                obj.SalutationName = Convert.ToString(postdata.name.ToString());
                obj.IsDeleted = Convert.ToBoolean(postdata.status.ToString());

                SALUTATIONBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetSM")
            {
                List<SALUTATION_Base> lst = new List<SALUTATION_Base>();
                lst = SALUTATIONBC.getdata();
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