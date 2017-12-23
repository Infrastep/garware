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
    /// Summary description for DocumentHandler
    /// </summary>
    public class DocumentHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertDOC")
            {
                DOCUMENTS_MASTER_Base obj = new DOCUMENTS_MASTER_Base();
                obj.DMID = Convert.ToInt32(postdata.id.ToString());

                obj.DMCODE = Convert.ToString(postdata.code.ToString());

                obj.DMDESCRIPTION = Convert.ToString(postdata.desc.ToString());

                if (postdata.path.ToString() != string.Empty) { obj.PATH = Convert.ToString(postdata.path.ToString()); }

                obj.ISSUE_DATE = Convert.ToDateTime(postdata.issuedate); //.ToString(format.ShortDatePattern)
                obj.ISSUE_PLACE = Convert.ToInt32(postdata.issueplace.ToString());
                obj.DT_ID = Convert.ToInt32(postdata.doctype.ToString());
                obj.EMP_ID = Convert.ToInt32(postdata.eid.ToString());
                obj.VALIDITY = Convert.ToDateTime(postdata.validity); //.ToString(format.ShortDatePattern)
                obj.LAST_MODIFY =DateTime.Now;
                DocumentBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetDOC")
            {
                DOCUMENTS_MASTER_Base eb = new DOCUMENTS_MASTER_Base();
                eb.EMP_ID = Convert.ToInt32(postdata.id.ToString());
                var lst = DocumentBC.getdatabyEmpId(eb);
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