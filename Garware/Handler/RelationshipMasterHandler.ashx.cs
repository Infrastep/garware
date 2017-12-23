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
    /// Summary description for RelationshipMasterHandler
    /// </summary>
    public class RelationshipMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertRSM")
            {
                RELATIONSHIP_MASTER_Base obj = new RELATIONSHIP_MASTER_Base();
                obj.RELATIONSHIPID = Convert.ToInt32(postdata.id.ToString());

                obj.RELATION = Convert.ToString(postdata.relation.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
                RelationShipMasterBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }
            if (data == "GetRSM")
            {
                List<RELATIONSHIP_MASTER_Base> lst = new List<RELATIONSHIP_MASTER_Base>();
                lst = RelationShipMasterBC.getdata();
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