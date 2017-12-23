using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
namespace Frontend.Handler
{
    /// <summary>
    /// Summary description for AddressMasterHandler
    /// </summary>
    public class AddressMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();

            if (data == "GetAMByCOMID")
            {
                List<ADDRESSEE_MASTER_Base> lst = new List<ADDRESSEE_MASTER_Base>();
                int id = Convert.ToInt32(postdata.id.ToString());
                lst = ADDRESSEE_MASTERBC.getdatabyCompanyId(id);
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "SendMail")
            {

                string toMail = Convert.ToString(postdata.tomail.ToString());
                string name = Convert.ToString(postdata.name.ToString());
                string email = Convert.ToString(postdata.email.ToString());
                string phone = Convert.ToString(postdata.phone.ToString());
                string query = Convert.ToString(postdata.query.ToString());
                bool status = UtilityBC.SendContactMail(name, toMail, email, phone, query);
                jstring = JsonConvert.SerializeObject(status);
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