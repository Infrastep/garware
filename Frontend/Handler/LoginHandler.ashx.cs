using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseClass;
using BuisnessController;
using Newtonsoft.Json;
using System.Web.Security;
namespace Frontend.Handler
{
    /// <summary>
    /// Summary description for LoginHandler
    /// </summary>
    public class LoginHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string jstring = string.Empty;
            System.IO.StreamReader str = new System.IO.StreamReader(context.Request.InputStream);
            string sBuf = str.ReadToEnd();
            dynamic postdata = JsonConvert.DeserializeObject(sBuf);
            string data = postdata.Method.ToString();

            if (data == "LoginUser")
            {
                int EmpId = 0;
                EmployeeBC objbc = new EmployeeBC();
                string uname = postdata.uname.ToString();
                string psw = postdata.psw.ToString();
               
                bool chk = Membership.ValidateUser(uname, psw);
                if (chk == true)
                {
                    FormsAuthentication.SetAuthCookie(uname, false);
                    MembershipUser mu = Membership.GetUser(uname);
                    string userId = mu.ProviderUserKey.ToString();
                
                    Guid id = new Guid(userId);
                   var lst = EmployeeBC.getEmpIDByGuid(id);
                   if (lst.EMPID != 0)
                   {
                       EmpId = lst.EMPID;
                       HttpCookie cookie = new HttpCookie("myEmpcookie");
                       cookie.Values.Add("fempid", lst.EMPID.ToString());
                       cookie.Values.Add("fname", "");
                       cookie.Values.Add("femail", "");
                       HttpContext.Current.Response.Cookies.Add(cookie);
                   }
                    
                }
                jstring = JsonConvert.SerializeObject(EmpId);
            }
            if (data == "CheckLoginUser")
            {
                string rolename = string.Empty;
                string[] roles = null;
                string chk = string.Empty;
                if (Membership.GetUser() != null)
                {
                    roles = Roles.GetRolesForUser(Membership.GetUser().UserName);
                    if (roles.Length > 0)
                    { rolename = roles[0]; }
                    chk = "true";
                }

                jstring = JsonConvert.SerializeObject(chk);
            }
            if (data == "RegisterUser")
            {
                EMP_FIXED_Base obj = new EMP_FIXED_Base();
                Guid aspnetid = Guid.Empty;
                string msg = string.Empty;
                string name = string.Empty;
                try
                {
                    string fname = postdata.fname.ToString();
                    string mname = postdata.mname.ToString();
                    string lname = postdata.lname.ToString();
                    string cdc = postdata.cdc.ToString();
                    string email = postdata.email.ToString();
                    string psw = postdata.psw.ToString();
                    if(mname !="")
                    {  name = fname + " " + mname + " " + lname; }
                    else
                    {  name = fname + " " + lname; }
                    int con = DocumentBC.getdataByDocType(cdc);
                    if (con == 0)
                    {
                        MembershipUser mu = Membership.CreateUser(email, psw, email);
                        aspnetid = new Guid(mu.ProviderUserKey.ToString());
                        msg = "success";
                        //obj.EMAIL = email;
                        //obj.EMP_NAME = name;
                        //obj.ASP_USER_DETAILS = aspnetid;
                        //var lst = EmployeeBC.insertupdateData(obj);
                        if (aspnetid != Guid.Empty)
                        {
                            FormsAuthentication.SetAuthCookie(email, false);
                            HttpCookie cookie = new HttpCookie("myEmpcookie");
                            cookie.Values.Add("fempid", "0");
                            cookie.Values.Add("fname", name);
                            cookie.Values.Add("femail", email);
                            HttpContext.Current.Response.Cookies.Add(cookie);
                        }
                    }
                    else
                    { msg = "You are allready registered,Please log in"; }
                }
                catch(Exception ee)
                { msg = ee.Message.ToString(); }

                jstring = JsonConvert.SerializeObject(msg);
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