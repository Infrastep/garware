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
    /// Summary description for PortMasterHandler
    /// </summary>
    public class PortMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertPM")
            {
                PORT_MASTER_Base obj = new PORT_MASTER_Base();
                obj.PID = Convert.ToInt32(postdata.id.ToString());
                obj.PortName = Convert.ToString(postdata.name.ToString());
                obj.CCODE = Convert.ToString(postdata.code.ToString());
                obj.Country = Convert.ToInt32(postdata.country.ToString());
                obj.addby = "";
                obj.editby = "";
                obj.addtime = DateTime.Now;
                obj.editime = DateTime.Now;
                obj.Latitude = Convert.ToString(postdata.lat.ToString());
                obj.Longitude = Convert.ToString(postdata.lon.ToString());
                obj.status = Convert.ToBoolean(postdata.status.ToString());

                PortMasterBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetPM")
            {
                List<PORT_MASTER_Base> lst = new List<PORT_MASTER_Base>();
                lst = PortMasterBC.getdata();
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