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
    /// Summary description for CurrencyMasterHandler
    /// </summary>
    public class CurrencyMasterHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertCURR")
            {
                CURRENCY_MASTER_Base obj = new CURRENCY_MASTER_Base();
                obj.Currency_id = Convert.ToInt32(postdata.id.ToString());
                obj.title = Convert.ToString(postdata.title.ToString());
                obj.code = Convert.ToString(postdata.code.ToString());
                obj.decimal_place = Convert.ToString(postdata.deci.ToString());
                obj.value = Convert.ToDecimal(postdata.value.ToString());
                obj.symbol_left = Convert.ToString(postdata.sleft.ToString());
                obj.symbol_right = Convert.ToString(postdata.sright.ToString());
                obj.status = Convert.ToBoolean(postdata.status.ToString());
                CURRENCY_MASTERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetCURR")
            {
                List<CURRENCY_MASTER_Base> lst = new List<CURRENCY_MASTER_Base>();
                lst = CURRENCY_MASTERBC.getdata();
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