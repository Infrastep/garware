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
    /// Summary description for TaxSlabHandler
    /// </summary>
    public class TaxSlabHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertTS")
            {
                TAX_SLAB_Base obj = new TAX_SLAB_Base();
                obj.ID = Convert.ToInt32(postdata.id.ToString());
                obj.FINANCIAL_YEAR = Convert.ToString(postdata.fyear.ToString());
                obj.FROM_AMT = Convert.ToDecimal(postdata.fromamt.ToString());
                obj.TO_AMT = Convert.ToDecimal(postdata.taxamt.ToString());
                obj.TAX_PER = Convert.ToDecimal(postdata.tax.ToString());
                obj.TAX_AMT = Convert.ToDecimal(postdata.taxamt.ToString());
                obj.TYPE = Convert.ToString(postdata.taxtype.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());

                TaxSlabBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject("Success");
            }


            if (data == "GetTS")
            {
                List<TAX_SLAB_Base> lst = new List<TAX_SLAB_Base>();
                lst = TaxSlabBC.getdata();
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