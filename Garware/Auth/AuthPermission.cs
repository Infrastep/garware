using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuisnessController;
namespace Garware.Auth
{
    public class AuthPermission : System.Web.UI.Page
    {
        public static string[] getper(string pagename, int level)
        {

            string[] roles; // need to write DB query to get roles from db (where clause pagename, permission level) 
            var myroles = new List<string>();
            var lst = PAGE_PERMISSIONBC.getdatabyPagename(pagename, level);
            if (lst.Count > 0)
            {
                for (int i = 0; i <= lst.Count - 1; i++)
                {
                    myroles.Add(Convert.ToString(lst[i].ROLENAME));
                     
                }
            }
            // currently just using static values in if statement for testing
            //if (level == 0) { roles = new string[] { "Subscriber" }; }
            //else if (level == 1) { roles = new string[] { "SuperAdmin", "A Level Verifier" }; }
            //else { roles = new string[] { "Client" }; }

            roles = myroles.ToArray();
            return roles;
        }

    }
}