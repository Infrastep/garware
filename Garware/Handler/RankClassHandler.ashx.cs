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
    /// Summary description for RankClassHandler
    /// </summary>
    public class RankClassHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertRCM")
            {
                RANK_CLASS_Base obj = new RANK_CLASS_Base();
                obj.RCID = Convert.ToInt32(postdata.id.ToString());
                obj.RANKID = Convert.ToInt32(postdata.rank.ToString());
                obj.CLASSID = Convert.ToInt32(postdata.classval.ToString());
                obj.Class_Type = postdata.classtype.ToString();
                
              


               dynamic jso= RankClassBC.insertupdateData(obj);

               jstring = JsonConvert.SerializeObject(jso);
            }


            if (data == "GetRCM")
            {
                List<RANK_CLASS_Base> lst = new List<RANK_CLASS_Base>();
                lst = RankClassBC.getdata();
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