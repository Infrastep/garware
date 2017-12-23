using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClass
{
   public class ASPNET_ROLES_Base
    {
       public ASPNET_ROLES_Base()
        {
            this.aspnet_Users = new HashSet<ASPNET_USER_Base>();
        }
    
        public System.Guid ApplicationId { get; set; }
        public System.Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string LoweredRoleName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ASPNET_USER_Base> aspnet_Users { get; set; }

    }
}
