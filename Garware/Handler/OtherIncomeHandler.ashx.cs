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
    /// Summary description for OtherIncomeHandler
    /// </summary>
    public class OtherIncomeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertOI")
            {
                OTHER_INCOME_Base obj = new OTHER_INCOME_Base();
                obj.ID = Convert.ToInt32(postdata.id.ToString());
                obj.DESCRIPTION = Convert.ToString(postdata.desc.ToString());
                obj.TYPE = Convert.ToString(postdata.type.ToString());
                obj.NON_TAXABLE_LIMIT = Convert.ToDecimal(postdata.nontax.ToString());


                OtherIncomeBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetOI")
            {
                List<OTHER_INCOME_Base> lst = new List<OTHER_INCOME_Base>();
                lst = OtherIncomeBC.getdata();
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