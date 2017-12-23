using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for imguploader
    /// </summary>
    public class imguploader : IHttpHandler
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
                     fname = context.Server.MapPath("~/uploads/" + file.FileName);
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