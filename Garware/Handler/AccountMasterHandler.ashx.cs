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
    /// Summary description for AccountMasterHandler
    /// </summary>
    public class AccountMasterHandler : IHttpHandler
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

                    ACCOUNT_MASTER_Base obj = new ACCOUNT_MASTER_Base();
                    obj.Id = Convert.ToInt32(postdata.id);
                    obj.Code = postdata.Code.ToString();
                    obj.Description =postdata.Description.ToString();
                    ACCOUNT_MASTERBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(ACCOUNT_MASTERBC.getdata());
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