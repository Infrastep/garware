using Garware.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garware
{
    public partial class Rule0 : AuthPermission
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginView1.RoleGroups[0].Roles = getper("Rule0", 3);

            LoginView1.RoleGroups[1].Roles = getper("Rule0", 2);

            LoginView1.RoleGroups[2].Roles = getper("Rule0", 1); 
        }
    }
}