using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using BaseClass;
using BuisnessController;
namespace Garware.Handler
{
    /// <summary>
    /// Summary description for GenerateAspUser
    /// </summary>
    public class GenerateAspUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
           
                
             var   lst = EmployeeBC.getdataNotIn().ToList();
               for(int i=0;i<lst.Count;i++)
               {
                   EMP_FIXED_Base obj = new EMP_FIXED_Base();

                   MembershipUser mu = Membership.CreateUser(lst[i].EMAIL, "temppass@123", lst[i].EMAIL.ToString());
                   Guid aspnetid = new Guid(mu.ProviderUserKey.ToString());
                   Roles.AddUserToRole(mu.UserName, "Subscriber");
                   lst[i].ASP_USER_DETAILS = aspnetid;
                   
                   dynamic jso = EmployeeBC.insertupdateData(lst[i]);
               }

               // jstring = JsonConvert.SerializeObject(lst);
            
            //context.Response.ContentType = "application / json";
            //context.Response.Write(jstring);
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