using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garware
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] rolea = new string[] { "Subscriber" };
            LoginView1.RoleGroups[0].Roles = rolea;

            string[] roleb = new string[] { "SuperAdmin", "A Level Verifier" };
            LoginView1.RoleGroups[1].Roles = roleb;

            string[] rolec = new string[] { "Client" };
            LoginView1.RoleGroups[2].Roles = rolec; 
        }
    }
}