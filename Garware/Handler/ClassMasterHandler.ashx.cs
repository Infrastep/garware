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
    /// Summary description for ClassMasterHandler
    /// </summary>
    public class ClassMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertCLS")
            {
                CLASS_Base obj = new CLASS_Base();
                obj.CLASSID = Convert.ToInt32(postdata.id.ToString());
                obj.CLASS_NAME = postdata.name.ToString();

                obj.ACTIVE = Convert.ToBoolean(postdata.stat.ToString());
                obj.CLASS_TYPE  = postdata.ct.ToString();
                obj.COST_TO_COMP = Convert.ToBoolean(postdata.ctc.ToString());

                CLASSBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetCLS")
            {
                //List<CLASS_Base> lst = new List<CLASS_Base>();
                //dynamic lst = CLASSBC.getdata();
                jstring = JsonConvert.SerializeObject(CLASSBC.getdata());
            }
            if (data == "GetCLSMAP")
            {
                jstring = JsonConvert.SerializeObject(CLASSBC.getdataMap(3));
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