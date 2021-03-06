﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for Company
    /// </summary>
    public class Company : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();



            if (data == "InsertCOMPANY")
            {
                COMPANY_PARAMETER_Base obj = new COMPANY_PARAMETER_Base();
                obj.COMPANYID = Convert.ToInt32(postdata.id.ToString());
                obj.COMPANY_NAME = Convert.ToString(postdata.companyname.ToString());
               
                obj.PHONE = Convert.ToString(postdata.phone.ToString());

                obj.FAX_NO = Convert.ToString(postdata.faxno.ToString());
                obj.EMAIL = Convert.ToString(postdata.email.ToString());
                obj.SERVICE_TAX_NO = Convert.ToString(postdata.servicetaxno.ToString());
                obj.PAN_NO = Convert.ToString(postdata.panno.ToString());
                obj.COMPANY_LOGO = Convert.ToString(postdata.companylogo.ToString());
                obj.STATUS = Convert.ToBoolean(postdata.status.ToString());
                dynamic jso = COMPANY_PARAMETERBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject(jso);
            }
            if (data == "GetCompany")
            {
                List<COMPANY_PARAMETER_Base> lst = new List<COMPANY_PARAMETER_Base>();
                lst = COMPANY_PARAMETERBC.getdata();
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