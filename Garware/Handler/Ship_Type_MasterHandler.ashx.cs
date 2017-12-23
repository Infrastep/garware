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
    /// Summary description for Ship_Type_MasterHandler
    /// </summary>
    public class Ship_Type_MasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
          


            if (data == "InsertSTM")
            {
                SHIP_TYPE_MASTER_Base obj = new SHIP_TYPE_MASTER_Base();
                obj.TypeID = Convert.ToInt32(postdata.id.ToString());
                
                obj.Description = Convert.ToString(postdata.description.ToString());
                obj.Status = Convert.ToBoolean(postdata.status.ToString());
                Ship_Type_MasterBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }
            if (data == "GetSTM")
            {
                List<SHIP_TYPE_MASTER_Base> lst = new List<SHIP_TYPE_MASTER_Base>();
                lst = Ship_Type_MasterBC.getdata();
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