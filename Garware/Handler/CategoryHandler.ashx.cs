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
    /// Summary description for CategoryHandler
    /// </summary>
    public class CategoryHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertCT")
            {
                CATEGORY_Base obj = new CATEGORY_Base();
                obj.CATEGORY_ID = Convert.ToInt32(postdata.id.ToString());
                obj.CATEGORY_NAME = Convert.ToString(postdata.cname.ToString());
                obj.CATEGORY_CODE = Convert.ToString(postdata.code.ToString());
               
               obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
               

                CATEGORYBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetCT")
            {
                List<CATEGORY_Base> lst = new List<CATEGORY_Base>();
                lst = CATEGORYBC.getdata();
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