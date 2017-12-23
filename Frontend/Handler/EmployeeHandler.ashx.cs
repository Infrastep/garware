using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System.Web.Security;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for EmployeeHandler
    /// </summary>
    public class EmployeeHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertEM")
            {
                EMP_FIXED_Base obj = new EMP_FIXED_Base();

                obj.EMPID = Convert.ToInt32(postdata.id.ToString());
                obj.EMP_NAME = postdata.name.ToString();

                if (postdata.paddress1.ToString() != "") { obj.ADDR_PRESENT1 = postdata.paddress1.ToString(); }
                if (postdata.paddress2.ToString() != "") { obj.ADDR_PRESENT2 = postdata.paddress2.ToString(); }

                if (postdata.pmaddress1.ToString() != "") { obj.ADDR_PRMNT1 = postdata.pmaddress1.ToString(); }
                if (postdata.pmaddress2.ToString() != "") { obj.ADDR_PRMNT2 = postdata.pmaddress2.ToString(); }

                if (postdata.pphone.ToString() != "") { obj.TELEPHONE_PRESENT = postdata.pphone.ToString(); }
                if (postdata.pmphone.ToString() != "") { obj.TELEPHONE_PRMNT = postdata.pmphone.ToString(); }

                if (postdata.bplace.ToString() != "") { obj.BIRTH_PLACE = postdata.bplace.ToString(); }

                obj.DOB = Convert.ToDateTime(postdata.dob.ToString());

                 obj.EMP_CODE = "";


                if (postdata.pmfax.ToString() != "") { obj.FAX = postdata.pmfax.ToString(); }

                if (postdata.pmmobile.ToString() != "") { obj.MOBILE = postdata.pmmobile.ToString(); }
                if (postdata.prefix.ToString() != "") { obj.NAME_PREFIX = postdata.prefix.ToString(); }
                obj.NATIONALITY = Convert.ToInt32(postdata.nationality.ToString());
               
                obj.PHOTO =  postdata.photo.ToString();

                obj.RELIGIONID = Convert.ToInt32(postdata.religion.ToString());
                obj.FATHER_NAME = postdata.fathername.ToString();
                obj.EMAIL = postdata.pmemail.ToString();
                obj.SEX = postdata.prefix.ToString();
                TimeSpan diff = DateTime.Now - Convert.ToDateTime(obj.DOB);
                double sp= diff.Days;
                if (sp >= 21900)
                { obj.SR_CITIZEN = true; }
                else
                { obj.SR_CITIZEN = false; }
               
                obj.STATUS = 1;
                obj.SIGNINGAUTH = false;
                obj.DESIGNATION = "";

                if (obj.EMPID == 0)
                {
                    string userId = Membership.GetUser().ProviderUserKey.ToString();
                    try
                    {
                        Roles.AddUserToRole(Membership.GetUser().UserName, "Subscriber");
                        Guid id = new Guid(userId);
                        obj.ASP_USER_DETAILS = id;
                        UtilityBC.SendMail(obj.EMP_NAME, obj.EMAIL);
                    }
                    catch { Guid id = new Guid(userId);
                        obj.ASP_USER_DETAILS = id; }
                }
                dynamic jso = EmployeeBC.insertupdateData(obj);


                //MembershipUser mu = Membership.CreateUser(obj.EMAIL, "temppass@123", obj.EMAIL.ToString());

                //Guid aspnetid = new Guid(mu.ProviderUserKey.ToString());
                //Roles.AddUserToRole(mu.UserName, "Subscriber");
                //obj.ASP_USER_DETAILS = aspnetid;
                //UtilityBC.SendMail(obj.EMP_NAME, obj.EMAIL);


                if (jso != null)
                {
                    HttpCookie cookie = new HttpCookie("myEmpcookie");
                    cookie.Values.Add("fempid", Convert.ToString(jso.EMPID));
                    cookie.Values.Add("fname", Convert.ToString(jso.EMP_NAME));
                    cookie.Values.Add("femail", Convert.ToString(jso.EMAIL));
                    HttpContext.Current.Response.Cookies.Add(cookie);

                  
                }
                jstring = JsonConvert.SerializeObject(jso);

            }

            if (data == "GetEM")
            {
                List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();
                lst = EmployeeBC.getdata();
                jstring = JsonConvert.SerializeObject(lst);
            }

            if (data == "GetEMByID")
            {

                int EMPID = Convert.ToInt32(postdata.id.ToString());
                var lst = EmployeeBC.getdata(EMPID);
                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "UpdateEmpImage")
            {

                int EMPID = Convert.ToInt32(postdata.id.ToString());
                string PATH = postdata.path.ToString();
                var lst = EmployeeBC.UpdateImage(EMPID, PATH);
                jstring = JsonConvert.SerializeObject(lst);
            }

            if (data == "GetEmpListForComment")
            {
                List<EMP_FIXED_Base> lst = new List<EMP_FIXED_Base>();
                int EmpID = Convert.ToInt32(postdata.empID.ToString());
                lst = EmployeeBC.getUserForMailsend(EmpID);
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