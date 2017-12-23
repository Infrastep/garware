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
    /// Summary description for AreaOperationMasterHandler
    /// </summary>
    public class AreaOperationMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            switch (data)
            {
                case "InsertUpdate":

                    AREA_OPERATION_MASTER_Base obj = new AREA_OPERATION_MASTER_Base();
                    obj.AREAID = Convert.ToInt32(postdata.id.ToString());
                    obj.AREACODE = Convert.ToString(postdata.AREACODE.ToString());
                    obj.NAME = Convert.ToString(postdata.NAME.ToString());
                    obj.DESCRIPTION = Convert.ToString(postdata.DESCRIPTION.ToString());
                    obj.ISINDIA = Convert.ToBoolean(postdata.ISINDIA.ToString());
                    AREA_OPERATION_MASTERBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(AREA_OPERATION_MASTERBC.getdata());
                    break;
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