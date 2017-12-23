using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garware.Handler
{
    /// <summary>
    /// Summary description for MiscTaxableIncomeHandler
    /// </summary>
    public class MiscTaxableIncomeHandler : IHttpHandler
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

                    MISC_TAXABLE_INCOME_Base obj = new MISC_TAXABLE_INCOME_Base();
                    obj.MISC_TAXABLE_INCOME_ID = Convert.ToInt32(postdata.MISC_TAXABLE_INCOME_ID.ToString());
                    obj.EMP_CODE = Convert.ToInt32(postdata.EMP_CODE.ToString());
                    obj.AMOUNT = Convert.ToDecimal(postdata.AMOUNT.ToString());
                    obj.FINANCIAL_YEAR = Convert.ToString(postdata.FINANCIAL_YEAR.ToString());
                    obj.NARRATION = Convert.ToString(postdata.NARRATION.ToString());
                    obj.INCOME_CODE = Convert.ToInt32(postdata.INCOME_CODE.ToString());
                    
                    obj.ENTRY_DATE = Convert.ToDateTime(postdata.ENTRY_DATE.ToString());
                    obj.UTILISED = Convert.ToDecimal(postdata.UTILISED.ToString());
                    obj.TAX_DED = Convert.ToDecimal(postdata.TAX_DED.ToString());
                    obj.TAX_AMT_DED = Convert.ToDecimal(postdata.TAX_AMT_DED.ToString());
                    //obj.HCESS_DED = Convert.ToDecimal(postdata.HCESS_DED.ToString());
                    obj.CESS_DED = Convert.ToDecimal(postdata.CESS_DED.ToString());
                    obj.SCHG_DED = Convert.ToDecimal(postdata.SCHG_DED.ToString());
                    obj.HCESS_DED = Convert.ToDecimal("0.00");
                    MISC_TAXABLE_INCOMEBC.insertupdateData(obj);

                    jstring = JsonConvert.SerializeObject("Success");
                    break;

                case "Getdata":

                    jstring = JsonConvert.SerializeObject(MISC_TAXABLE_INCOMEBC.getdata());
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