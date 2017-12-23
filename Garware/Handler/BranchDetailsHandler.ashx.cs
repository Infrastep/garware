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
    /// Summary description for BranchDetailsHandler
    /// </summary>
    public class BranchDetailsHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertBD")
            {
                BRANCH_DETAILS_Base obj = new BRANCH_DETAILS_Base();

                obj.BRANCHID = Convert.ToInt32(postdata.id.ToString());
                obj.IFSCCODE = postdata.ifsccode.ToString();
                obj.MICRCODE = postdata.micrcode.ToString();
                obj.SWIFTCODE = postdata.swiftcode.ToString();
                obj.ADDRESS1 = postdata.address1.ToString();
                if (postdata.address2 != null)
                { obj.ADDRESS2 = postdata.address2.ToString(); }
                else
                {
                    obj.ADDRESS2 = "";
                }

                obj.PIN = postdata.pin.ToString();
                obj.CITY = postdata.city.ToString();

                obj.STATE = postdata.state.ToString();
                if (postdata.countryid != "null")
                {
                    obj.COUNTRYID = Convert.ToInt32(postdata.countryid.ToString());
                }
                else
                { obj.COUNTRYID = 0; }
                if (postdata.bankid != "null")
                {
                    obj.BANKID = Convert.ToInt32(postdata.bankid.ToString()); 
                }
                else
                { obj.BANKID = 0; }
                BRANCH_DETAILSBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetBDByBANKID")
            {
                int id = Convert.ToInt32(postdata.id.ToString());
                List<BRANCH_DETAILS_Base> lst = new List<BRANCH_DETAILS_Base>();

                lst = BRANCH_DETAILSBC.getdata().Where(q => q.BANKID == id).ToList();

                jstring = JsonConvert.SerializeObject(lst);
            }

            if (data == "GetBD")
            {
               
                List<BRANCH_DETAILS_Base> lst = new List<BRANCH_DETAILS_Base>();

                lst = BRANCH_DETAILSBC.getdata().ToList();

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