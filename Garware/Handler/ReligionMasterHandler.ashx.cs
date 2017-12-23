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
    /// Summary description for ReligionMasterHandler
    /// </summary>
    public class ReligionMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertRGM")
            {
                RELIGION_Base obj = new RELIGION_Base();
                obj.RELIGIONID = Convert.ToInt32(postdata.id.ToString());

                obj.RELIGION_NAME = Convert.ToString(postdata.name.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
              
                ReligionMasterBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetRGM")
            {
                List<RELIGION_Base> lst = new List<RELIGION_Base>();
                lst = ReligionMasterBC.getdata();
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