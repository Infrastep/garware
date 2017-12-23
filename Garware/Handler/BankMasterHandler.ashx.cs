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
    /// Summary description for BankMasterHandler
    /// </summary>
    public class BankMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertBM")
            {
                BANK_MASTER_Base obj = new BANK_MASTER_Base();
                obj.BANKID = Convert.ToInt32(postdata.id.ToString());
                obj.BANK_NAME = Convert.ToString(postdata.name.ToString());
                obj.BANK_CODE = Convert.ToString(postdata.code.ToString());
                
                obj.ACTIVE_BANK = Convert.ToBoolean(postdata.status.ToString());
                obj.ADD_TIME = DateTime.Now;
                obj.EDIT_TIME = DateTime.Now;
                obj.ADD_BY = "";
                obj.EDIT_BY = "";

                BANK_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }

            if (data == "GetBM")
            {
                List<BANK_MASTER_Base> lst = new List<BANK_MASTER_Base>();
                lst = BANK_MASTERBC.getdata();
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