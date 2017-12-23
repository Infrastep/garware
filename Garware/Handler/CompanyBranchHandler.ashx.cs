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
    /// Summary description for CompanyBranch
    /// </summary>
    public class CompanyBranch : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;

            if (data == "InsertCBM")
            {
                COMPANY_BRANCH_Base obj = new COMPANY_BRANCH_Base();

                obj.CBID = Convert.ToInt32(postdata.id.ToString());
                obj.BRANCHID = Convert.ToInt32(postdata.branch);
                obj.COMPANYID = Convert.ToInt32(postdata.cid.ToString());
                obj.CHEQUE_NAME = postdata.chq.ToString();

                dynamic jso = COMPANY_BRANCHBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject(jso);
            }

            if (data == "GetCB")
            {
                COMPANY_BRANCH_Base eb = new COMPANY_BRANCH_Base();
                //List<EmpBranchBase> lst = new List<EmpBranchBase>();
                eb.COMPANYID = Convert.ToInt32(postdata.id.ToString());
                var lst = COMPANY_BRANCHBC.getdatabyComId(eb);
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