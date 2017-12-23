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
    /// Summary description for PagePermissionHandler
    /// </summary>
    public class PagePermissionHandler : IHttpHandler
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

                    PAGE_PERMISSION_Base obj = new PAGE_PERMISSION_Base();
                    obj.PAGEPERMISSIONID = Convert.ToInt32(postdata.PAGEPERMISSIONID.ToString());
                    //obj.PAGEID = Convert.ToInt32(postdata.PAGEID.ToString());
                    //Guid roleid = new Guid(postdata.ROLEID.ToString());
                    //obj.ROLENAME = Convert.ToString(postdata.ROLENAME.ToString());
                    obj.PERMISSIONID = Convert.ToInt32(postdata.PERMISSIONID.ToString());
                    
                    PAGE_PERMISSIONBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "GetdataByRolename":
                    string ROLENAME = Convert.ToString(postdata.ROLENAME.ToString());;
                    jstring = JsonConvert.SerializeObject(PAGE_PERMISSIONBC.getdatabyRolename(ROLENAME));
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