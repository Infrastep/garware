using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuisnessController;
using System.Web.Security;

namespace Frontend.Handler
{
    /// <summary>
    /// Summary description for Uploader
    /// </summary>
    public class Uploader : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Files.Count > 0)
            {
                HttpFileCollection files = context.Request.Files;
                string fname = string.Empty;
                string filename = string.Empty;
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    string userId = Membership.GetUser().ProviderUserKey.ToString();
                    Guid id = new Guid(userId);
                    int empID = EmployeeBC.getEmpIDByGuid(id).EMPID;

                    string idpath = "~/uploads/" + empID.ToString() + "/";
                    bool exists = System.IO.Directory.Exists(idpath);

                    if (!exists)
                        System.IO.Directory.CreateDirectory(context.Server.MapPath(idpath));


                    fname = context.Server.MapPath(idpath + file.FileName);
                    file.SaveAs(fname);
                    filename = file.FileName;
                }
                context.Response.ContentType = "text/plain";
                context.Response.Write(filename);
            } 
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