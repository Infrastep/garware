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
    /// Summary description for EmpExperienceHandler
    /// </summary>
    public class EmpExperienceHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertEE")
            {
                EMP_EXPERIENCE_Base obj = new EMP_EXPERIENCE_Base();



                obj.EEID = Convert.ToInt32(postdata.id.ToString());

                obj.EMP_id = Convert.ToInt32(postdata.eid.ToString());
                obj.Ship_name = postdata.ship.ToString();
                obj.Company_Served = postdata.company.ToString();
                obj.Ship_Type = postdata.shiptype.ToString();
                obj.DWT = postdata.dwt.ToString();
                obj.Engine = postdata.engine.ToString();
                obj.BHP = postdata.bhp.ToString();
              
                obj.Rank = postdata.rank.ToString();
                obj.Months = Convert.ToInt16(postdata.months.ToString());
                obj.Days = Convert.ToInt16(postdata.days.ToString());
                obj.DIRECT = Convert.ToBoolean(postdata.direct.ToString());
                obj.Service_From = Convert.ToDateTime(postdata.from.ToString());
                obj.Service_To = Convert.ToDateTime(postdata.to.ToString());

                obj.Area_Sp_Job = postdata.Area_Sp_Job.ToString();
                obj.Area_Operation = postdata.Area_Operation.ToString();


                dynamic jso = EmpExperienceBC.insertupdateData(obj);

                jstring = JsonConvert.SerializeObject(jso);
            }

            if (data == "GetEE")
            {
                EMP_EXPERIENCE_Base eb = new EMP_EXPERIENCE_Base();
               // var lst = new List<EMP_EXPERIENCE_Base>();
                eb.EMP_id = Convert.ToInt32(postdata.id.ToString());
                var lst = EmpExperienceBC.getdatabyEmpId(eb);
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