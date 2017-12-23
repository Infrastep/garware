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
                EmployeeBC objbc = new EmployeeBC();
                string uname = postdata.uname.ToString();
                string psw = postdata.psw.ToString();
                bool chk= Membership.ValidateUser(uname, psw);
                if (chk == true)
                {
                    string rolename = string.Empty;
                    string[] roles = null;
                    FormsAuthentication.SetAuthCookie(uname, false);
                    MembershipUser mu = Membership.GetUser(uname);
                    string userId = mu.ProviderUserKey.ToString();
                    Guid id = new Guid(userId);
                    roles = Roles.GetRolesForUser(uname);
                    if (roles.Length > 0)
                    { rolename = roles[0]; }
                    
                    var lst = EmployeeBC.getEmpIDByGuid(id);
                    HttpCookie cookie = new HttpCookie("mylogcookie");
                    cookie.Values.Add("empid", lst.EMPID.ToString());
                    cookie.Values.Add("email", lst.EMAIL.ToString());
                    cookie.Values.Add("role", rolename.ToString());

                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                jstring = JsonConvert.SerializeObject(chk);
            }
            if (data == "CheckLoginUser")
            {
                string rolename = string.Empty;
                string[] roles = null;
               
                if(Membership.GetUser() !=null)
                {
                    var usr = Roles.GetUsersInRole("Subscriber");
                    roles=Roles.GetRolesForUser(Membership.GetUser().UserName);
                    if (roles.Length > 0)
                    { rolename = roles[0]; }
                    
                }

                jstring = JsonConvert.SerializeObject(rolename);
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