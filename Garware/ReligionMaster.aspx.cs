using Garware.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garware
{
    public partial class ReligionMaster : AuthPermission
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoginView1.RoleGroups[0].Roles = getper("ReligionMaster", 3);

            LoginView1.RoleGroups[1].Roles = getper("ReligionMaster", 2);

            LoginView1.RoleGroups[2].Roles = getper("ReligionMaster", 1); 

        }
    }
}