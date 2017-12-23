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
    /// Summary description for EmployeeBranchHandler
    /// </summary>
    public class EmployeeBranchHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertEBM")
            {
                EMP_BRANCH_Base obj = new EMP_BRANCH_Base();

                obj.EBID = Convert.ToInt32(postdata.id.ToString());
                obj.BRANCHID = Convert.ToInt32(postdata.branch);
                obj.EMPID = Convert.ToInt32(postdata.eid.ToString());
                obj.BANK_AC_NO_NRE = postdata.accno.ToString();
                obj.NOT_PF = Convert.ToBoolean(postdata.pf);

                dynamic jso = EmpBranchBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject(jso);
            }

            if (data == "GetEBM")
            {
                EMP_BRANCH_Base eb = new EMP_BRANCH_Base();
              //List<EmpBranchBase> lst = new List<EmpBranchBase>();
                eb.EMPID = Convert.ToInt32(postdata.id.ToString());
                var lst = EmpBranchBC.getdatabyEmpId(eb);
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