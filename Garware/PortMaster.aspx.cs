using Garware.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garware
{
    public partial class PortMaster : AuthPermission
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginView1.RoleGroups[0].Roles = getper("PortMaster", 3);

            LoginView1.RoleGroups[1].Roles = getper("PortMaster", 2);

            LoginView1.RoleGroups[2].Roles = getper("PortMaster", 1); 
        }
    }
}