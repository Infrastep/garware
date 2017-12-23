using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System.Web.Security;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for EmployeeGridHandler
    /// </summary>
    public class EmployeeGridHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            string jstring = string.Empty;
            DateTime stdt = DateTime.Now.AddYears(-1); DateTime enddt = DateTime.Now;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            int st = Convert.ToInt32(context.Request["iDisplayStart"]);
            int lt = Convert.ToInt32(context.Request["iDisplayLength"]);
            string scl = context.Request["iSortingCols"];
            int sec = Convert.ToInt32(context.Request["sEcho"]);
            string serchval = context.Request["sSearch"];


            List<EMP_FIXED_Base> total = EmployeeBC.getSubscriber().OrderByDescending(q => q.EMPID).ToList();
            helper h1 = new helper();
            List<EMP_FIXED_Base> filter2 = new List<EMP_FIXED_Base>();
            h1.draw = sec;

            filter2 = total;
            //List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();

            //lst = EmployeeBC.getdata().OrderByDescending(q => q.EMPID).ToList();


            //jstring = JsonConvert.SerializeObject(lst);

            if (lt != -1)
            {
                h1.data = filter2.Skip(st).Take(lt).ToList();
            }
            else
            {
                h1.data = filter2;
            }

            h1.recordsFiltered = filter2.Count;
            h1.recordsTotal = total.Count;
            jstring = JsonConvert.SerializeObject(h1);
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