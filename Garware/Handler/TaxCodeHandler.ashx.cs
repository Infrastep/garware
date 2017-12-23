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
    /// Summary description for TaxCodeHandler
    /// </summary>
    public class TaxCodeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertTC")
            {
                TAX_CODE_Base obj = new TAX_CODE_Base();
                obj.ID = Convert.ToInt32(postdata.id.ToString());
                obj.DESCRIPTIONS = Convert.ToString(postdata.desc.ToString());
                obj.SAVINGS_TYPE = Convert.ToString(postdata.stype.ToString());
                obj.UNDER_SECTION = Convert.ToInt32(postdata.undersec.ToString());
               


                TaxCodeBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetTC")
            {
                List<TAX_CODE_Base> lst = new List<TAX_CODE_Base>();
                lst = TaxCodeBC.getdata();
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