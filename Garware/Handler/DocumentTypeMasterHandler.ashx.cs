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
    /// Summary description for DocumentTypeMasterHandler
    /// </summary>
    public class DocumentTypeMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertDocType")
            {
                DOCUMENTS_TYPE_Base obj = new DOCUMENTS_TYPE_Base();
                obj.DTID = Convert.ToInt32(postdata.id.ToString());
                obj.DTNAME = Convert.ToString(postdata.dtname.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
                DOCUMENTTYPE_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }
            if (data == "GetDocType")
            {
                List<DOCUMENTS_TYPE_Base> lst = new List<DOCUMENTS_TYPE_Base>();
                lst = DOCUMENTTYPE_MASTERBC.getdata();
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