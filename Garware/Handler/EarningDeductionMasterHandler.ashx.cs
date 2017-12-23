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
    /// Summary description for EarningDeductionMasterHandler
    /// </summary>
    public class EarningDeductionMasterHandler : IHttpHandler
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

                    EARNING_DEDUCTION_MASTER_Base obj = new EARNING_DEDUCTION_MASTER_Base();
                    obj.EARNDEDNID = Convert.ToInt16(postdata.id.ToString());
                    obj.CODE = Convert.ToString(postdata.CODE.ToString());
                    
                    obj.DESCRIPTION = Convert.ToString(postdata.DESCRIPTION.ToString());
                    
                    EARNING_DEDUCTION_MASTERBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(EARNING_DEDUCTION_MASTERBC.getdata());
                    break;
                case "GetdataByID":
                    int EARNDEDNID = Convert.ToInt32(postdata.EarnDednID.ToString());
                    jstring = JsonConvert.SerializeObject(EARNING_DEDUCTION_MASTERBC.getdata(EARNDEDNID));
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