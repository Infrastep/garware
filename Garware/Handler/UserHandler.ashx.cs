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
    /// Summary description for UserHandler
    /// </summary>
    public class UserHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();
            System.Globalization.DateTimeFormatInfo format = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;


            if (data == "InsertUM")
            {
                dynamic jso = null;
                EMP_FIXED_Base obj = new EMP_FIXED_Base();
                try
                {


                    obj.EMPID = Convert.ToInt32(postdata.id.ToString());
                    obj.EMP_NAME = postdata.name.ToString();

                    obj.ADDR_PRESENT1 = ""; obj.ADDR_PRESENT2 = "";

                    obj.ADDR_PRMNT1 = ""; obj.ADDR_PRMNT2 = "";

                    obj.TELEPHONE_PRESENT = ""; obj.TELEPHONE_PRMNT = "";

                    obj.BIRTH_PLACE = "";

                    //obj.DOB = Convert.ToDateTime(postdata.dob.ToString());

                    obj.EMP_CODE = ""; obj.FAX = "";

                    obj.MOBILE = postdata.pmmobile.ToString();
                     obj.NAME_PREFIX = postdata.prefix.ToString(); 
                    obj.NATIONALITY = 1;
                    obj.PHOTO = postdata.photo.ToString();

                    obj.RELIGIONID = Convert.ToInt32(1);
                    obj.FATHER_NAME = "";
                    obj.EMAIL = postdata.pmemail.ToString();
                    obj.SEX = postdata.prefix.ToString();
                    obj.SR_CITIZEN = false;
                    obj.STATUS = Convert.ToInt32(postdata.status.ToString());
                    obj.SIGNINGAUTH = Convert.ToBoolean(postdata.auth.ToString());
                    obj.DESIGNATION = Convert.ToString(postdata.dsgn.ToString());
                    string RoleName = postdata.rolename.ToString();
                    if (obj.EMPID == 0)
                    {
                        MembershipUser mu = Membership.CreateUser(obj.EMAIL, "temppass@123", obj.EMAIL.ToString());
                        Guid aspnetid = new Guid(mu.ProviderUserKey.ToString());
                        Roles.AddUserToRole(mu.UserName, RoleName);
                        obj.ASP_USER_DETAILS = aspnetid;
                        UtilityBC.SendMail(obj.EMP_NAME, obj.EMAIL);
                    }
                    jso = EmployeeBC.insertupdateData(obj);
                }
                catch (Exception ff)
                { jso = "error"; }

                jstring = JsonConvert.SerializeObject(jso);
            }

            if (data == "GetUM")
            {

                List<USER_ROLE_Base> lst = new List<USER_ROLE_Base>();

                lst = USER_ROLEBC.getdata().ToList();


                jstring = JsonConvert.SerializeObject(lst);
            }
            if (data == "GetRoles")
            {
                string[] roles = null;

                string[] roleNames = Roles.GetRolesForUser();
                roles = Roles.GetAllRoles();
                
                //roles.Where(q => q != roleNames[0]);
                jstring = JsonConvert.SerializeObject(roles);
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